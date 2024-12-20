﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VRChatHeartRateMonitor
{
    public partial class MainForm : Form
    {
        private UpdateHandler _updateHandler;

        private System.Windows.Forms.Timer _heartbeatEffectTimer;
        private DeviceHandler _deviceHandler;
        private Dictionary<ulong, string> _deviceMap = new Dictionary<ulong, string>();

        private CancellationTokenSource _autoConnectCountdownCancellationToken;

        private VRChatOscHandler _vrchatOscHandler;
        private WebServerHandler _webServerHandler;

        private List<Icon> _icons = new List<Icon>();

        private string _lastConnectedDeviceAddress = "";

        private bool _useChatbox = true;
        private ushort _chatboxAppearance = 0;

        private bool _useAvatar = false;
        private string _avatarParameter = "heartRate";

        private bool _useWebServer = false;
        private ushort _webServerPort = 6969;

        public MainForm()
        {
            InitializeComponent();
            InitializeConfig();
            InitializeIcons();
            InitializeForm();
            InitializeUpdate();
            InitializeHeartbeatEffect();
            InitializeDeviceHandler();
            InitializeVRChatOscHandler();
            InitializeWebServerHandler();
        }

        private void SafeInvoke(Action action)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(action);
                }
                catch (ObjectDisposedException){}
            else
                action();
        }

        private void InitializeConfig()
        {
            _lastConnectedDeviceAddress = RegistryHelper.GetValue("last_connected_device_address", _lastConnectedDeviceAddress);

            _useChatbox = RegistryHelper.GetValue("use_chatbox", _useChatbox);
            _chatboxAppearance = ushort.Parse(RegistryHelper.GetValue("chatbox_appearance", _chatboxAppearance.ToString()));

            _useAvatar = RegistryHelper.GetValue("use_avatar", _useAvatar);
            _avatarParameter = RegistryHelper.GetValue("avatar_parameter", _avatarParameter);

            _useWebServer = RegistryHelper.GetValue("use_web_server", _useWebServer);
            _webServerPort = ushort.Parse(RegistryHelper.GetValue("web_server_port", _webServerPort.ToString()));
        }

        private void InitializeIcons()
        {
            Image mainIcon = Properties.Resources.heart;

            for (int i = 0; i <= 254; i++)
            {
                Image smalIcon = ScaleImage(mainIcon, 32, 32);

                if (i > 0)
                {
                    using (Graphics graphics = Graphics.FromImage(smalIcon))
                    using (Font font = new Font("Cascadia Mono", 14, FontStyle.Bold))
                        graphics.DrawString(i.ToString(), font, Brushes.Yellow, new PointF((i >= 100 ? -4 : 3), 4));
                }

                _icons.Add(Icon.FromHandle(((Bitmap)smalIcon).GetHicon()));
            }

            ResetIcons();
        }

        private Image ScaleImage(Image image, int width, int height)
        {
            Bitmap scaledImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(scaledImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return scaledImage;
        }

        private void ResetIcons()
        {
            this.Icon = _icons.ElementAt(0);
            labelHeartRateDisplay.Visible = false;
            notifyIcon.Icon = _icons.ElementAt(0);
            notifyIcon.Text = "Status: Inactive";
        }

        private void SetIcons(ushort heartRate)
        {
            this.Icon = _icons.ElementAt(heartRate);
            labelHeartRateDisplay.Visible = true;
            labelHeartRateDisplay.Text = heartRate.ToString();
            notifyIcon.Icon = _icons.ElementAt(heartRate);
            notifyIcon.Text = "Status: Active\nHeart Rate: " + heartRate;
        }

        private void InitializeForm()
        {
            this.FormClosing += MainForm_FormClosing;
            this.Text = HeartRateMonitor.GetAssemblyTitle();
            labelInfoAppName.Text = HeartRateMonitor.GetAssemblyTitle();

            checkBoxUseChatbox.Checked = _useChatbox;
            checkBoxUseChatbox_CheckedChanged(checkBoxUseChatbox, EventArgs.Empty);

            comboBoxChatboxAppearance.SelectedIndex = _chatboxAppearance;

            checkBoxUseAvatar.Checked = _useAvatar;
            checkBoxUseAvatar_CheckedChanged(checkBoxUseAvatar, EventArgs.Empty);

            textBoxAvatarParameter.Text = _avatarParameter;
            textBoxAvatarParameter.KeyPress += new KeyPressEventHandler(textBox_KeyPressAlphanumeric);

            checkBoxUseWebServer.Checked = _useWebServer;
            checkBoxUseWebServer_CheckedChanged(checkBoxUseWebServer, EventArgs.Empty);

            textBoxWebServerPort.Text = _webServerPort.ToString();
            textBoxWebServerPort.KeyPress += new KeyPressEventHandler(textBox_KeyPressNumeric);
            textBoxWebServerPort.Leave += new EventHandler(textBoxWebServerPort_Leave);

            notifyIcon.MouseClick += NotifyIcon_MouseClick;

            labelHeartRateDisplay.Parent = pictureBoxHeartRateDisplay;
            labelBatteryLevel.Parent = labelHeartRateDisplay;
            labelBatteryLevel.Text = "";
        }

        private void InitializeUpdate()
        {
            _updateHandler = new UpdateHandler();
            _updateHandler.UpdateAvailable += UpdateHandler_UpdateAvailable;

            _updateHandler.CheckForUpdates();
        }

        private void UpdateHandler_UpdateAvailable(string updateUrl, string currentVersion, string latestVersion)
        {
            SafeInvoke(() => {
                if (HeartRateMonitor.ActionMessageBox($"There's a new update available!\n\nWould You like to update from version {currentVersion} to {latestVersion}?"))
                {
                    if (_updateHandler.Update(updateUrl))
                        this.Close();
                    else
                        HeartRateMonitor.ErrorMessageBox("An error occurred during the update process. Please try again or download the application again from the official source: " + updateUrl);
                }
            });
        }

        private void InitializeHeartbeatEffect()
        {
            _heartbeatEffectTimer = new System.Windows.Forms.Timer();
            _heartbeatEffectTimer.Interval = 300;
            _heartbeatEffectTimer.Tick += HeartbeatEffectTimer_Tick;
        }

        private async void HeartbeatEffectTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 1; i++)
            {
                panelHeartRateDisplay.Padding = new Padding(i == 1 ? 0 : 4);

                await Task.Delay(_heartbeatEffectTimer.Interval / 2);
            }
        }

        private void InitializeDeviceHandler()
        {
            _deviceHandler = new DeviceHandler();
            _deviceHandler.AdapterError += DeviceManager_AdapterError;
            _deviceHandler.DeviceFound += DeviceManager_DeviceFound;
            _deviceHandler.DeviceConnecting += DeviceManager_DeviceConnecting;
            _deviceHandler.DeviceConnected += DeviceManager_DeviceConnected;
            _deviceHandler.DeviceDisconnecting += DeviceManager_DeviceDisconnecting;
            _deviceHandler.DeviceDisconnected += DeviceManager_DeviceDisconnected;
            _deviceHandler.DeviceError += DeviceManager_DeviceError;
            _deviceHandler.HeartRateUpdated += DeviceManager_HeartRateUpdated;
            _deviceHandler.BatteryLevelUpdated += DeviceManager_BatteryLevelUpdated;

            comboBoxDevices.Items.Add("Scanning for Bluetooth Devices...");
            comboBoxDevices.SelectedIndex = 0;

            _deviceHandler.StartScanning();
        }

        private void DeviceManager_AdapterError()
        {
            SafeInvoke(() => {
                if (HeartRateMonitor.ActionMessageBox("Bluetooth adapter couldn't handle connection, make sure it's enabled in your system and has full Bluetooth Low Energy compatibility!\n\nWould You like to try again?"))
                    _deviceHandler.StartScanning();
                else
                    this.Close();
            });
        }

        private void DeviceManager_DeviceFound(ulong bluetoothDeviceAddress, string bluetoothDeviceName)
        {
            SafeInvoke(() => AddDeviceToComboBox(bluetoothDeviceAddress, bluetoothDeviceName));
        }

        private void DeviceManager_DeviceConnecting()
        {
            SafeInvoke(() => {
                buttonExecute.Text = "CONNECTING...";
                buttonExecute.Enabled = false;
                comboBoxDevices.Enabled = false;
            });
        }

        private void DeviceManager_DeviceConnected(ulong bluetoothDeviceAddress)
        {
            SafeInvoke(() => {
                buttonExecute.Text = "DISCONNECT";
                buttonExecute.Enabled = true;
                _heartbeatEffectTimer.Start();
                _deviceHandler.StopScanning();

                StartHandlers();

                _lastConnectedDeviceAddress = _deviceHandler.BluetoothAddressToString(bluetoothDeviceAddress);
                RegistryHelper.SetValue("last_connected_device_address", _lastConnectedDeviceAddress);
            });
        }

        private void DeviceManager_DeviceDisconnecting()
        {
            SafeInvoke(() => {
                buttonExecute.Text = "DISCONNECTING...";
                buttonExecute.Enabled = false;
            });
        }

        private void DeviceManager_DeviceDisconnected()
        {
            SafeInvoke(() => {
                buttonExecute.Text = "CONNECT";
                buttonExecute.Enabled = true;
                _heartbeatEffectTimer.Stop();
                _deviceHandler.StartScanning();

                StopHandlers();

                comboBoxDevices.Enabled = true;
                labelBatteryLevel.Text = "";

                ResetIcons();
            });
        }

        private void DeviceManager_DeviceError(string message)
        {
            SafeInvoke(() => {
                message += "\n\nPlease try reconnecting. If the issue persists, follow these simple troubleshooting steps:\n\n1. Restart the app.\n2. Toggle Bluetooth off, wait 10 seconds, then turn it back on.\n3. Restart your heart rate monitor.\n\nNote: Even if you resolve the issue, please report it on our Discord server to help us improve the app.";
                HeartRateMonitor.ErrorMessageBox(message);
            });
        }

        private void DeviceManager_HeartRateUpdated(ushort heartRate)
        {
            SafeInvoke(() => {
                SetIcons(heartRate);
            });
        }

        private void DeviceManager_BatteryLevelUpdated(ushort batteryLevel)
        {
            SafeInvoke(() => {
                labelBatteryLevel.Text = $"⚡{batteryLevel}%";
            });
        }

        private void AddDeviceToComboBox(ulong bluetoothDeviceAddress, string bluetoothDeviceName)
        {
            if (_deviceMap.Count == 0)
            {
                comboBoxDevices.Items.RemoveAt(0);
                buttonExecute.Enabled = true;
            }


            if (!_deviceMap.ContainsKey(bluetoothDeviceAddress))
            {
                _deviceMap.Add(bluetoothDeviceAddress, bluetoothDeviceName);
                comboBoxDevices.Items.Add(bluetoothDeviceName);

                if (comboBoxDevices.DroppedDown)
                {
                    comboBoxDevices.DroppedDown = false;
                    comboBoxDevices.DroppedDown = true;
                }
                
                if (_lastConnectedDeviceAddress == _deviceHandler.BluetoothAddressToString(bluetoothDeviceAddress))
                {
                    comboBoxDevices.SelectedIndex = comboBoxDevices.Items.Count - 1;
                    StartAutoConnectCountdown(bluetoothDeviceAddress);
                    comboBoxDevices.DroppedDown = false;
                }
                else if (comboBoxDevices.Items.Count == 1)
                {
                    comboBoxDevices.SelectedIndex = 0;
                }
            }
        }

        private void InitializeVRChatOscHandler()
        {
            _vrchatOscHandler = new VRChatOscHandler();
            _vrchatOscHandler.RequestHeartRate = (() => _deviceHandler.GetHeartRate());
        }

        private void InitializeWebServerHandler()
        {
            _webServerHandler = new WebServerHandler();
            _webServerHandler.RequestHeartRate = (() => _deviceHandler.GetHeartRate());
        }

        private void StartHandlers()
        {
            if (_useChatbox || _useAvatar)
                _vrchatOscHandler.Start(_useChatbox, _chatboxAppearance, _useAvatar, _avatarParameter);

            if (_useWebServer)
                _webServerHandler.Start(_webServerPort);
        }

        private void StopHandlers()
        {
            if (_useChatbox || _useAvatar)
                _vrchatOscHandler.Stop();

            if (_useWebServer)
                _webServerHandler.Stop();
        }

        private async void StartAutoConnectCountdown(ulong bluetoothDeviceAddress)
        {
            _autoConnectCountdownCancellationToken = new CancellationTokenSource();

            try
            {
                for (int i = 3; i > 0; i--)
                {
                    SafeInvoke(() => buttonExecute.Text = ("AUTO-CONNECT IN " + i + "S..."));

                    await Task.Delay(1000, _autoConnectCountdownCancellationToken.Token);
                }

                _deviceHandler.SubscribeToDevice(bluetoothDeviceAddress);
            }
            catch (TaskCanceledException)
            {
                DeviceManager_DeviceDisconnected();
            }

            _autoConnectCountdownCancellationToken = null;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (_autoConnectCountdownCancellationToken != null)
            {
                _autoConnectCountdownCancellationToken.Cancel();
            }
            else if (_deviceHandler.IsListening())
            {
                _deviceHandler.UnsubscribeFromDevice();
            }
            else if(_deviceHandler.CanConnect())
            {
                ulong? selectedBluetoothDeviceAddress = _deviceMap.FirstOrDefault(d => d.Value == comboBoxDevices.SelectedItem.ToString()).Key;

                if (comboBoxDevices.SelectedItem == null || selectedBluetoothDeviceAddress == null)
                {
                    HeartRateMonitor.ErrorMessageBox("Please select device from the list!");
                    return;
                }

                _deviceHandler.SubscribeToDevice((ulong)selectedBluetoothDeviceAddress);
            }
        }

        private void checkBoxUseChatbox_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxChatboxAppearance.Enabled = checkBoxUseChatbox.Checked;
        }

        private void checkBoxUseAvatar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAvatarParameter.ReadOnly = !checkBoxUseAvatar.Checked;
        }

        private void textBox_KeyPressAlphanumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        private void checkBoxUseWebServer_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWebServerPort.ReadOnly = !checkBoxUseWebServer.Checked;
        }

        private void textBox_KeyPressNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxWebServerPort_Leave(object sender, EventArgs e)
        {
            if (!ushort.TryParse(textBoxWebServerPort.Text, out ushort result) || result < 1 || result > 65535)
            {
                textBoxWebServerPort.Text = _webServerPort.ToString();
                textBoxWebServerPort.Focus();
                HeartRateMonitor.InfoMessageBox("Web server can only be running on ports from 1 to 65535, please provide a valid port!");
            }
        }

        private void AvatarParameterInfo_Click(object sender, EventArgs e)
        {
            HeartRateMonitor.InfoMessageBox($"To use this option you need to edit your VRChat avatar in Unity. New float paramater /avatar/parameters/{_avatarParameter} (from -1.0 to 1.0 - precision of 1/127) will be send through VRChat OSC. You need to add it to parameters, make sure that it's syncedm but not saved, and create animation which displays the heart rate. For more details about avatar configuration check Richard's video ;)");
        }

        private void buttonWebServerPortInfo_Click(object sender, EventArgs e)
        {
            HeartRateMonitor.InfoMessageBox($"This option is useful for streamers or more advanced users who wants to do something more with capetured heart rate data, it'll be availabe at http://localohst:{_webServerPort} (make sure to configure port that isn't already taken) so you can display it in OBS or do whatever you want with it.");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_deviceHandler.IsListening())
            {
                StopHandlers();
            }

            _useChatbox = checkBoxUseChatbox.Checked;
            RegistryHelper.SetValue("use_chatbox", _useChatbox);

            _chatboxAppearance = (ushort)comboBoxChatboxAppearance.SelectedIndex;
            RegistryHelper.SetValue("chatbox_appearance", _chatboxAppearance);

            _useAvatar = checkBoxUseAvatar.Checked;
            RegistryHelper.SetValue("use_avatar", _useAvatar);

            _avatarParameter = textBoxAvatarParameter.Text;
            RegistryHelper.SetValue("avatar_parameter", _avatarParameter);

            _useWebServer = checkBoxUseWebServer.Checked;
            RegistryHelper.SetValue("use_web_server", _useWebServer);

            _webServerPort = ushort.Parse(textBoxWebServerPort.Text);
            RegistryHelper.SetValue("web_server_port", _webServerPort);

            HeartRateMonitor.SuccessMessageBox("Configuration saved!");

            if (_deviceHandler.IsListening())
            {
                StartHandlers();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopHandlers();

            _vrchatOscHandler.RequestHeartRate = null;
            _vrchatOscHandler = null;

            _webServerHandler.RequestHeartRate = null;
            _webServerHandler = null;

            _deviceHandler.AdapterError -= DeviceManager_AdapterError;
            _deviceHandler.DeviceFound -= DeviceManager_DeviceFound;
            _deviceHandler.DeviceConnecting -= DeviceManager_DeviceConnecting;
            _deviceHandler.DeviceConnected -= DeviceManager_DeviceConnected;
            _deviceHandler.DeviceDisconnecting -= DeviceManager_DeviceDisconnecting;
            _deviceHandler.DeviceDisconnected -= DeviceManager_DeviceDisconnected;
            _deviceHandler.DeviceError -= DeviceManager_DeviceError;
            _deviceHandler.HeartRateUpdated -= DeviceManager_HeartRateUpdated;
            _deviceHandler.BatteryLevelUpdated -= DeviceManager_BatteryLevelUpdated;

            if (_deviceHandler.IsListening())
                _deviceHandler.UnsubscribeFromDevice();
            else
                _deviceHandler.StopScanning();

            _deviceHandler = null;
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;

                this.Show();
                this.Activate();
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void linkLabelFooterWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://virgosky.com") { UseShellExecute = true });
        }

        private void pictureBoxFooterDiscord_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://virgosky.com/dc") { UseShellExecute = true });
        }

        private void linkLabelInfoAuthorUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://virgosky.com") { UseShellExecute = true });
        }

        private void linkLabelInfoProjectUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/RichardVirgosky/VRChat-Heart-Rate-Monitor") { UseShellExecute = true });
        }
    }
}
