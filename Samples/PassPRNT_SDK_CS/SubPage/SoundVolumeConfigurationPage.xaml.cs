using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class SoundVolumeConfigurationPage : Page
    {
        string key = "soundvolume";

        public SoundVolumeConfigurationPage()
        {
            this.InitializeComponent();
            SoundVolumePreference.ItemsSource = Settings.SoundVolumePreference;
            SoundVolumePreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.SoundVolumePreference.Count; i++)
            {
                string str = Settings.SoundVolumePreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    SoundVolumePreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void SoundVolume_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.SoundVolumePreference[SoundVolumePreference.SelectedIndex]);
            Settings.setValue(key, Settings.SoundVolumePreference[SoundVolumePreference.SelectedIndex]);
        }
    }
}