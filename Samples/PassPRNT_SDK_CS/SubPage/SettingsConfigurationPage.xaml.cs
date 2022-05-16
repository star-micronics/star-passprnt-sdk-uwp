using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class SettingsConfigurationPage : Page
    {
        string key = "settings";

        public SettingsConfigurationPage()
        {
            this.InitializeComponent();
            SettingsPreference.ItemsSource = Settings.SettingsPreference;
            SettingsPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.SettingsPreference.Count; i++)
            {
                string str = Settings.SettingsPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    SettingsPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void SettingsPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.SettingsPreference[SettingsPreference.SelectedIndex]);
            Settings.setValue(key, Settings.SettingsPreference[SettingsPreference.SelectedIndex]);
        }
    }
}
