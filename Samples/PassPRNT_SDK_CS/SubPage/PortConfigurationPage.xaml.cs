using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class PortConfigurationPage : Page
    {
        string key = "port";

        public PortConfigurationPage()
        {
            this.InitializeComponent();
            PortPreference.ItemsSource = Settings.PortPreference;
            PortPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.PortPreference.Count; i++)
            {
                string str = Settings.PortPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    PortPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void PortPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.PortPreference[PortPreference.SelectedIndex]);
            Settings.setValue(key, Settings.PortPreference[PortPreference.SelectedIndex]);
        }
    }
}
