using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class TimeoutConfigurationPage : Page
    {
        string key = "timeout";

        public TimeoutConfigurationPage()
        {
            this.InitializeComponent();
            TimeoutPreference.ItemsSource = Settings.TimeoutPreference;
            TimeoutPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.TimeoutPreference.Count; i++)
            {
                string str = Settings.TimeoutPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    TimeoutPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void TimeoutPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.TimeoutPreference[TimeoutPreference.SelectedIndex]);
            Settings.setValue(key, Settings.TimeoutPreference[TimeoutPreference.SelectedIndex]);
        }
    }
}
