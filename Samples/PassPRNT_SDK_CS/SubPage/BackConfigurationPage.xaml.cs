using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class BackConfigurationPage : Page
    {
        string key = "back";

        public BackConfigurationPage()
        {
            this.InitializeComponent();
            BackPreference.ItemsSource = Settings.BackPreference;
            BackPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.BackPreference.Count; i++)
            {
                string str = Settings.BackPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    BackPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BackPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.BackPreference[BackPreference.SelectedIndex]);
            Settings.setValue(key, Settings.BackPreference[BackPreference.SelectedIndex]);
        }
    }
}
