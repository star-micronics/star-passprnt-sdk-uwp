using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class SoundConfigurationPage : Page
    {
        string key = "sound";

        public SoundConfigurationPage()
        {
            this.InitializeComponent();
            SoundPreference.ItemsSource = Settings.SoundPreference;
            SoundPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.SoundPreference.Count; i++)
            {
                string str = Settings.SoundPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    SoundPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void Sound_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.SoundPreference[SoundPreference.SelectedIndex]);
            Settings.setValue(key, Settings.SoundPreference[SoundPreference.SelectedIndex]);
        }
    }
}