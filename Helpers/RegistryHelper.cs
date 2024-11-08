using Microsoft.Win32;

namespace VRChatHeartRateMonitor
{
    internal class RegistryHelper
    {
        private const string RegistryKeyPath = @"HKEY_CURRENT_USER\Software\VRChatHeartRateMonitor";

        public static T GetValue<T>(string valueName, T defaultValue)
        {
            object value = Registry.GetValue(RegistryKeyPath, valueName, defaultValue);

            if (value is T result)
                return result;
            else if (typeof(T) == typeof(bool) && value is int intValue)
                return (T)(object)(intValue != 0);

            return defaultValue;
        }

        public static void SetValue<T>(string valueName, T value)
        {
            if (value is bool boolValue)
                Registry.SetValue(RegistryKeyPath, valueName, boolValue ? 1 : 0);
            else
                Registry.SetValue(RegistryKeyPath, valueName, value);
        }
    }
}
