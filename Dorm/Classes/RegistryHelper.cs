using Microsoft.Win32;

namespace PresentationLayer
{
    public class RegistryHelper
    {
        public RegistryHelper()
        {
        }

        public void CreateSubKey()
        {
            RegistryKey mainKey = Registry.Users;
            mainKey.OpenSubKey(@"HKEY_USERS\DEFAULT");
            string[] array = mainKey.GetSubKeyNames();
            foreach (string str in array)
            {
                System.Windows.Forms.MessageBox.Show(str);
            }
            mainKey.Flush();
            mainKey.Close();
        }

        public void RemoveSubKey(string SubKeyName)
        {
            //RegistryKey r = mainKey.OpenSubKey(".DEFAULT", true);
            //r.DeleteSubKey(SubKeyName);
        }

        public void SetValue(string SubKeyName, string ValueName, object value)
        {
            //RegistryKey r = mainKey.OpenSubKey(".DEFAULT\\" + SubKeyName, true);
            //r.SetValue(ValueName, value);
        }

        public void RemoveValue(string SubKeyName, string ValueName)
        {
            //RegistryKey r = mainKey.OpenSubKey(".DEFAULT\\" + SubKeyName, true);
            //r.DeleteValue(ValueName);
        }

        public object GetValue(string SubKeyName, string ValueName)
        {
            //RegistryKey r = mainKey.OpenSubKey(".DEFAULT\\" + SubKeyName, true);
            //object value = r.GetValue(ValueName);
            //return value;
            return null;
        }
    }
}