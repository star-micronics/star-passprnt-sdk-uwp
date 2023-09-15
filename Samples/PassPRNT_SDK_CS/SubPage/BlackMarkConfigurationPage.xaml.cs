using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class BlackMarkConfigurationPage : Page
    {
        string key = "blackmark";

        public BlackMarkConfigurationPage()
        {
            this.InitializeComponent();
            BlackmarkPreference.ItemsSource = Settings.BlackmarkPreference;
            BlackmarkPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.BlackmarkPreference.Count; i++)
            {
                string str = Settings.BlackmarkPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    BlackmarkPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BlackmarkPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.BlackmarkPreference[BlackmarkPreference.SelectedIndex]);
            Settings.setValue(key, Settings.BlackmarkPreference[BlackmarkPreference.SelectedIndex]);
        }
    }
}
