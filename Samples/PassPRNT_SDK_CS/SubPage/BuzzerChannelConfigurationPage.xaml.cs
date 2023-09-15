using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class BuzzerChannelConfigurationPage : Page
    {
        string key = "buzzerchannel";

        public BuzzerChannelConfigurationPage()
        {
            this.InitializeComponent();
            BuzzerChannelPreference.ItemsSource = Settings.BuzzerChannelPreference;
            BuzzerChannelPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.BuzzerChannelPreference.Count; i++)
            {
                string str = Settings.BuzzerChannelPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    BuzzerChannelPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BuzzerChannelPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.BuzzerChannelPreference[BuzzerChannelPreference.SelectedIndex]);
            Settings.setValue(key, Settings.BuzzerChannelPreference[BuzzerChannelPreference.SelectedIndex]);
        }
    }
}
