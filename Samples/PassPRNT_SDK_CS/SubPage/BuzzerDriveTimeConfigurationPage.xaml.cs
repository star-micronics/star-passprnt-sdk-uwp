using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class BuzzerDriveTimeConfigurationPage : Page
    {
        string key = "buzzerdrivetime";

        public BuzzerDriveTimeConfigurationPage()
        {
            this.InitializeComponent();
            BuzzerDriveTimePreference.ItemsSource = Settings.BuzzerDriveTimePreference;
            BuzzerDriveTimePreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.BuzzerDriveTimePreference.Count; i++)
            {
                string str = Settings.BuzzerDriveTimePreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    BuzzerDriveTimePreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BuzzerDriveTimePreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.BuzzerDriveTimePreference[BuzzerDriveTimePreference.SelectedIndex]);
            Settings.setValue(key, Settings.BuzzerDriveTimePreference[BuzzerDriveTimePreference.SelectedIndex]);
        }
    }
}
