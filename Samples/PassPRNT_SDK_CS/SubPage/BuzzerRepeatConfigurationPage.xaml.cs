using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class BuzzerRepeatConfigurationPage : Page
    {
        string key = "buzzerrepeat";

        public BuzzerRepeatConfigurationPage()
        {
            this.InitializeComponent();
            BuzzerRepeatPreference.ItemsSource = Settings.BuzzerRepeatPreference;
            BuzzerRepeatPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.BuzzerRepeatPreference.Count; i++)
            {
                string str = Settings.BuzzerRepeatPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    BuzzerRepeatPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BuzzerRepeatPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.BuzzerRepeatPreference[BuzzerRepeatPreference.SelectedIndex]);
            Settings.setValue(key, Settings.BuzzerRepeatPreference[BuzzerRepeatPreference.SelectedIndex]);
        }
    }
}
