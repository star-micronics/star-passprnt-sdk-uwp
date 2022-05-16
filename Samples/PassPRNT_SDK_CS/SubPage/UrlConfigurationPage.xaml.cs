using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class UrlConfigurationPage : Page
    {
        string key = "url";

        public UrlConfigurationPage()
        {
            this.InitializeComponent();
            UrlPreference.ItemsSource = Settings.UrlPreference;
            UrlPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.UrlPreference.Count; i++)
            {
                string str = Settings.UrlPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    UrlPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void UrlPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.UrlPreference[UrlPreference.SelectedIndex]);
            Settings.setValue(key, Settings.UrlPreference[UrlPreference.SelectedIndex]);
        }
    }
}