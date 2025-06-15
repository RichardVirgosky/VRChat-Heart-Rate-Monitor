using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections.Generic;

namespace VRChatHeartRateMonitor
{
    internal class DeviceHandler
    {
        private LinkedList<(DateTime timestamp, ushort heartRate)> _heartRateList = new LinkedList<(DateTime timestamp, ushort heartRate)>();
        private ushort _batteryLevel = 0;
        private BluetoothLEAdvertisementWatcher _bluetoothLEAdvertisementWatcher;
        private BluetoothLEDevice _device;
        private bool _allowDeviceToConnect = true;
        public enum DeviceStatus
        {
            Idle,
            Connecting,
            Reconnecting,
            Connected,
            Disconnecting
        }

        private DeviceStatus _status = DeviceStatus.Idle;
        public DeviceStatus Status => _status;

        private GattCharacteristic _heartRateCharacteristic;

        private Guid _heartRateServiceUuid = Guid.Parse("0000180D-0000-1000-8000-00805f9b34fb");
        private Guid _heartRateCharacteristicUuid = Guid.Parse("00002A37-0000-1000-8000-00805f9b34fb");

        private GattCharacteristic _batteryLevelCharacteristic;

        private Guid _batteryLevelServiceUuid = Guid.Parse("0000180F-0000-1000-8000-00805f9b34fb");
        private Guid _batteryLevelCharacteristicUuid = Guid.Parse("00002A19-0000-1000-8000-00805f9b34fb");

        private string _errorMessage = null;

        public event Action AdapterError;
        public event Action<ulong, string> DeviceFound;
        public event Action DeviceConnecting;
        public event Action DeviceReconnecting;
        public event Action<ulong, bool> DeviceConnected;
        public event Action DeviceDisconnecting;
        public event Action DeviceDisconnected;
        public event Action<string> DeviceError;
        public event Action<ushort> HeartRateUpdated;
        public event Action<ushort> BatteryLevelUpdated;

        public static async Task<bool> CheckCompatibility()
        {
            BluetoothAdapter bluetoothAdapter = await BluetoothAdapter.GetDefaultAsync();

            return (bluetoothAdapter != null && bluetoothAdapter.IsLowEnergySupported);
        }

        public DeviceHandler()
        {
            _bluetoothLEAdvertisementWatcher = new BluetoothLEAdvertisementWatcher
            {
                ScanningMode = BluetoothLEScanningMode.Active
            };

            _bluetoothLEAdvertisementWatcher.Received += async (sender, args) => await OnAdvertisementReceivedAsync(args);
        }

        public void StartScanning()
        {
            try
            {
                _bluetoothLEAdvertisementWatcher.Start();
            }
            catch (Exception)
            {
                AdapterError?.Invoke();
            }
        }

        private async Task OnAdvertisementReceivedAsync(BluetoothLEAdvertisementReceivedEventArgs args)
        {
            try
            {
                BluetoothLEDevice bluetoothDevice = await BluetoothLEDevice.FromBluetoothAddressAsync(args.BluetoothAddress);

                if (bluetoothDevice != null)
                {
                    var result = await bluetoothDevice.GetGattServicesForUuidAsync(_heartRateServiceUuid);

                    if (result.Status == GattCommunicationStatus.Success && result.Services.Count > 0)
                    {
                        DeviceFound?.Invoke(bluetoothDevice.BluetoothAddress, GetDeviceName(bluetoothDevice));
                    }
                }
            }
            catch (Exception){}
        }

        public void StopScanning()
        {
            _bluetoothLEAdvertisementWatcher.Stop();
        }

        private async Task<GattDeviceService> GetService(Guid serviceUuid)
        {
            var result = await _device?.GetGattServicesForUuidAsync(serviceUuid, BluetoothCacheMode.Uncached);

            if (result.Status == GattCommunicationStatus.Success && result.Services.Count > 0)
            {
                return result.Services.First();
            }

            return null;
        }

        private async Task<GattCharacteristic> GetCharacteristic(Guid serviceUuid, Guid characteristicUuid)
        {
            GattDeviceService service = await GetService(serviceUuid);

            if (service != null)
            {
                var result = await service.GetCharacteristicsForUuidAsync(characteristicUuid, BluetoothCacheMode.Uncached);

                if (result.Status == GattCommunicationStatus.Success && result.Characteristics.Count > 0)
                {
                    return result.Characteristics.First();
                }
            }

            return null;
        }

        private async Task<GattCharacteristic> GetHeartRateCharacteristic(bool reconnecting)
        {
            for (int attempt = 0; attempt < 60; attempt++)
            {
                GattCharacteristic heartRateCharacteristic = await GetCharacteristic(_heartRateServiceUuid, _heartRateCharacteristicUuid);

                if (reconnecting || heartRateCharacteristic != null)
                    return heartRateCharacteristic;

                await Task.Delay(1000);
            }

            return null;
        }

        private async Task<GattCharacteristic> GetBatteryLevelCharacteristic()
        {
            return await GetCharacteristic(_batteryLevelServiceUuid, _batteryLevelCharacteristicUuid);
        }

        private async Task<bool> SubscibeToCharacteristicNotifications(GattCharacteristic characteristic)
        {
            try
            {
                GattCommunicationStatus characteristicCommunicationStatus = await characteristic?.WriteClientCharacteristicConfigurationDescriptorAsync(GattClientCharacteristicConfigurationDescriptorValue.Notify);
                
                return (characteristicCommunicationStatus == GattCommunicationStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task<bool> SubscibeToHeartRateCharacteristicNotifications()
        {
            for (int attempt = 0; attempt < 60; attempt++)
            {
                if (await SubscibeToCharacteristicNotifications(_heartRateCharacteristic))
                    return true;

                await Task.Delay(1000);
            }

            return false;
        }

        private async Task<bool> SubscibeToBatteryLevelCharacteristicNotifications()
        {
            return await SubscibeToCharacteristicNotifications(_batteryLevelCharacteristic);
        }

        private async Task UnsubscibeToCharacteristicNotifications(GattCharacteristic characteristic)
        {
            try
            {
                await characteristic.WriteClientCharacteristicConfigurationDescriptorAsync(GattClientCharacteristicConfigurationDescriptorValue.None);
            }
            catch {}
        }

        private async Task CleanupCharacteristic(GattCharacteristic characteristic)
        {
            if (characteristic != null)
            {
                await UnsubscibeToCharacteristicNotifications(characteristic);

                try
                {
                    characteristic?.Service?.Dispose();
                }
                catch (ObjectDisposedException) {}
            }
        }

        private async Task CleanupDevice()
        {
            _device.ConnectionStatusChanged -= Device_ConnectionStatusChanged;

            await CleanupCharacteristic(_heartRateCharacteristic);

            await CleanupCharacteristic(_batteryLevelCharacteristic);

            try
            {
                _device?.Dispose();
            }
            catch (ObjectDisposedException) { }
        }

        public async void SubscribeToDevice(ulong bluetoothDeviceAddress, ushort connectAttempt = 0)
        {
            if (_allowDeviceToConnect)
            {
                if (connectAttempt > 0)
                {
                    _status = DeviceStatus.Reconnecting;
                    DeviceReconnecting?.Invoke();
                }
                else
                {
                    _status = DeviceStatus.Connecting;
                    DeviceConnecting?.Invoke();

                    _heartRateList.Clear();
                    _batteryLevel = 0;
                }

                _device = await BluetoothLEDevice.FromBluetoothAddressAsync(bluetoothDeviceAddress);

                _errorMessage = null;

                try
                {
                    if (_device == null)
                    {
                        _errorMessage = "Bluetooth device error - Couldn't connect to the device!";
                    }
                    else if (_allowDeviceToConnect)
                    {
                        _heartRateCharacteristic = await GetHeartRateCharacteristic(connectAttempt == 0);

                        if (_allowDeviceToConnect)
                        {
                            if (_heartRateCharacteristic == null && connectAttempt > 0 && connectAttempt < 600)
                            {
                                await Task.Delay(1000);
                                SubscribeToDevice(bluetoothDeviceAddress, ++connectAttempt);
                                return;
                            }
                            else if (_heartRateCharacteristic != null)
                            {
                                if (await SubscibeToHeartRateCharacteristicNotifications())
                                {
                                    _device.ConnectionStatusChanged += Device_ConnectionStatusChanged;
                                    _heartRateCharacteristic.ValueChanged += HeartRateCharacteristic_ValueChanged;

                                    _batteryLevelCharacteristic = await GetBatteryLevelCharacteristic();

                                    if (_batteryLevelCharacteristic != null && await SubscibeToBatteryLevelCharacteristicNotifications())
                                    {
                                        BatteryLevelUpdated?.Invoke(0);

                                        _batteryLevelCharacteristic.ValueChanged += BatteryLevelCharacteristic_ValueChanged;

                                        var firstBatteryLevelValue = await _batteryLevelCharacteristic.ReadValueAsync();

                                        if (firstBatteryLevelValue.Status == GattCommunicationStatus.Success)
                                        {
                                            SetBatteryLevel(firstBatteryLevelValue.Value.ToArray());
                                        }
                                    }

                                    DeviceConnected?.Invoke(_device.BluetoothAddress, connectAttempt > 0);
                                    _status = DeviceStatus.Connected;
                                }
                                else
                                {
                                    _errorMessage = "Bluetooth device error - Couldn't subscribe to the characteristic notifications!";
                                }
                            }
                            else if (!_device.DeviceInformation.Pairing.IsPaired)
                            {
                                if (_device.DeviceInformation.Pairing.CanPair)
                                {
                                    DeviceInformationCustomPairing customDeviceParing = _device.DeviceInformation.Pairing.Custom;
                                    customDeviceParing.PairingRequested += (sender, args) => args.Accept();

                                    DevicePairingResult pairingResult = await customDeviceParing.PairAsync(DevicePairingKinds.ConfirmOnly);

                                    if (pairingResult.Status == DevicePairingResultStatus.Paired || pairingResult.Status == DevicePairingResultStatus.AlreadyPaired)
                                    {
                                        _device.Dispose();

                                        await Task.Delay(15000);

                                        SubscribeToDevice(bluetoothDeviceAddress);
                                        return;
                                    }
                                    else
                                    {
                                        _errorMessage = "Bluetooth device error while paring with the device!";
                                    }
                                }
                                else
                                {
                                    _errorMessage = "Bluetooth device error - Can't pair with the device!";
                                }
                            }
                            else
                            {
                                _errorMessage = "Bluetooth device error - Couldn't find the heart rate characteristic!";
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    _errorMessage = "Bluetooth device error - Unexpected failure!\n" + e.Message + "\n" + e.StackTrace;
                }
            }

            if (_status != DeviceStatus.Connected)
            {
                if (_errorMessage != null && connectAttempt == 0)
                {
                    DeviceError?.Invoke(_errorMessage);
                }

                await UnsubscribeFromDevice();
            }
        }

        private async void Device_ConnectionStatusChanged(BluetoothLEDevice sender, object args)
        {
            if (sender.ConnectionStatus == BluetoothConnectionStatus.Disconnected)
            {
                await CleanupDevice();

                SubscribeToDevice(sender.BluetoothAddress, 1);
            }
        }

        public async Task UnsubscribeFromDevice(bool callActions = true)
        {
            _status = DeviceStatus.Disconnecting;
            DeviceDisconnecting?.Invoke();

            HeartRateUpdated?.Invoke(GetHeartRate());

            await CleanupDevice();

            await Task.Delay(500);

            DeviceDisconnected?.Invoke();
            _status = DeviceStatus.Idle;
        }

        public async Task ForceDisconnect()
        {
            if (_allowDeviceToConnect)
            {
                while (_status != DeviceStatus.Idle)
                {
                    if (_status == DeviceStatus.Connected)
                    {
                        await UnsubscribeFromDevice();
                    }
                    else
                    {
                        _allowDeviceToConnect = false;
                        DeviceDisconnecting?.Invoke();
                        HeartRateUpdated?.Invoke(GetHeartRate());
                    }

                    await Task.Delay(500);
                }

                _allowDeviceToConnect = true;
            }
        }

        private void HeartRateCharacteristic_ValueChanged(GattCharacteristic sender, GattValueChangedEventArgs args)
        {
            if (_status == DeviceStatus.Connected)
            {
                byte[] data;

                using (var reader = DataReader.FromBuffer(args.CharacteristicValue))
                {
                    data = new byte[args.CharacteristicValue.Length];
                    reader.ReadBytes(data);
                }

                if (data.Length >= 2)
                {
                    byte flags = data[0];
                    bool isHeartRateInUInt16 = (flags & 0x01) != 0;

                    ushort newHeartRate = (isHeartRateInUInt16 ? BitConverter.ToUInt16(data, 1) : data[1]);

                    if (newHeartRate > 0)
                    {
                        if (newHeartRate > 254) newHeartRate = 254;

                        if (newHeartRate != GetHeartRate())
                        {
                            HeartRateUpdated?.Invoke(newHeartRate);
                        }

                        _heartRateList.AddLast((DateTime.UtcNow, newHeartRate));

                        DateTime heartRateListThreshold = (DateTime.UtcNow - TimeSpan.FromMinutes(5));

                        while (_heartRateList.Count > 0 && _heartRateList.First.Value.timestamp < heartRateListThreshold)
                        {
                            _heartRateList.RemoveFirst();
                        }
                    }
                }
            }
        }

        private void SetBatteryLevel(byte[] data)
        {
            ushort newBatteryLevel = data.First();

            if (newBatteryLevel != _batteryLevel)
            {
                _batteryLevel = newBatteryLevel;
                BatteryLevelUpdated?.Invoke(newBatteryLevel);
            }
        }

        private void BatteryLevelCharacteristic_ValueChanged(GattCharacteristic sender, GattValueChangedEventArgs args)
        {
            if (_status == DeviceStatus.Connected)
            {
                SetBatteryLevel(args.CharacteristicValue.ToArray());
            }
        }

        public ushort GetHeartRate()
        {
            if (_heartRateList.Count > 0 && (_status == DeviceStatus.Connected || _status == DeviceStatus.Reconnecting))
                return _heartRateList.Last.Value.heartRate;

            return 0;
        }

        public ushort GetAverageHeartRate()
        {
            if (_heartRateList.Count == 0)
                return 0;

            try
            {
                return (ushort)Math.Round(_heartRateList.Average(s => s.heartRate));
            }
            catch (InvalidOperationException)
            {
                return GetAverageHeartRate();
            }
        }

        public string BluetoothAddressToString(ulong bluetoothAddress)
        {
            return string.Join(":", Enumerable.Range(0, 6).Select(i => $"{bluetoothAddress:X12}".Substring(i * 2, 2)));
        }

        public string GetDeviceAddress(BluetoothLEDevice bluetoothDevice = null)
        {
            if (bluetoothDevice == null)
                bluetoothDevice = _device;

            return BluetoothAddressToString(bluetoothDevice.BluetoothAddress);
        }

        public string GetDeviceName(BluetoothLEDevice bluetoothDevice = null)
        {
            if (bluetoothDevice == null)
                bluetoothDevice = _device;

            return bluetoothDevice.Name + " (" + GetDeviceAddress(bluetoothDevice) + ")";
        }
    }
}
