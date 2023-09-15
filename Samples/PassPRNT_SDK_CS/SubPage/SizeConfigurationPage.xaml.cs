using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class SizeConfigurationPage : Page
    {
        string key = "size";

        public SizeConfigurationPage()
        {
            this.InitializeComponent();
            SizePreference.ItemsSource = Settings.SizePreference;
            SizePreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.SizePreference.Count; i++)
            {
                string str = Settings.SizePreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    SizePreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void SizePreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.SizePreference[SizePreference.SelectedIndex]);
            Settings.setValue(key, Settings.SizePreference[SizePreference.SelectedIndex]);
        }
    }
}
