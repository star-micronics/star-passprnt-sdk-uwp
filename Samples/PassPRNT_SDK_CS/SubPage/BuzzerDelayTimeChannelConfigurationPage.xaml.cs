using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class BuzzerDelayTimeConfigurationPage : Page
    {
        string key = "buzzerdelaytime";

        public BuzzerDelayTimeConfigurationPage()
        {
            this.InitializeComponent();
            BuzzerDelayTimePreference.ItemsSource = Settings.BuzzerDelayTimePreference;
            BuzzerDelayTimePreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.BuzzerDelayTimePreference.Count; i++)
            {
                string str = Settings.BuzzerDelayTimePreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    BuzzerDelayTimePreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BuzzerDelayTimePreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.BuzzerDelayTimePreference[BuzzerDelayTimePreference.SelectedIndex]);
            Settings.setValue(key, Settings.BuzzerDelayTimePreference[BuzzerDelayTimePreference.SelectedIndex]);
        }
    }
}
