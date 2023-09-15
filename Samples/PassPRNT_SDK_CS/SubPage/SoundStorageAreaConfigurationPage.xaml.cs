using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class SoundStorageAreaConfigurationPage : Page
    {
        string key = "soundstoragearea";

        public SoundStorageAreaConfigurationPage()
        {
            this.InitializeComponent();
            SoundStorageAreaPreference.ItemsSource = Settings.SoundStorageAreaPreference;
            SoundStorageAreaPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.SoundStorageAreaPreference.Count; i++)
            {
                string str = Settings.SoundStorageAreaPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    SoundStorageAreaPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void SoundStorageArea_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.SoundStorageAreaPreference[SoundStorageAreaPreference.SelectedIndex]);
            Settings.setValue(key, Settings.SoundStorageAreaPreference[SoundStorageAreaPreference.SelectedIndex]);
        }
    }
}