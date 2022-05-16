using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class SoundNumberConfigurationPage : Page
    {
        string key = "soundnumber";

        public SoundNumberConfigurationPage()
        {
            this.InitializeComponent();
            SoundNumberPreference.ItemsSource = Settings.SoundNumberPreference;
            SoundNumberPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.SoundNumberPreference.Count; i++)
            {
                string str = Settings.SoundNumberPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    SoundNumberPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void SoundNumber_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.SoundNumberPreference[SoundNumberPreference.SelectedIndex]);
            Settings.setValue(key, Settings.SoundNumberPreference[SoundNumberPreference.SelectedIndex]);
        }
    }
}