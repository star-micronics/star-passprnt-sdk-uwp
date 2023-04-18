using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class GapConfigurationPage : Page
    {
        string key = "gap";

        public GapConfigurationPage()
        {
            this.InitializeComponent();
            GapPreference.ItemsSource = Settings.GapPreference;
            GapPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.GapPreference.Count; i++)
            {
                string str = Settings.GapPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    GapPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void GapPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.GapPreference[GapPreference.SelectedIndex]);
            Settings.setValue(key, Settings.GapPreference[GapPreference.SelectedIndex]);
        }
    }
}
