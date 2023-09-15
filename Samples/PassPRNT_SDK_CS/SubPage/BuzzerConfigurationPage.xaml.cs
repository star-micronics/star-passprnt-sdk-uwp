using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class BuzzerConfigurationPage : Page
    {
        string key = "buzzer";

        public BuzzerConfigurationPage()
        {
            this.InitializeComponent();
            BuzzerPreference.ItemsSource = Settings.BuzzerPreference;
            BuzzerPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.BuzzerPreference.Count; i++)
            {
                string str = Settings.BuzzerPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    BuzzerPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void Buzzer_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.BuzzerPreference[BuzzerPreference.SelectedIndex]);
            Settings.setValue(key, Settings.BuzzerPreference[BuzzerPreference.SelectedIndex]);
        }
    }
}