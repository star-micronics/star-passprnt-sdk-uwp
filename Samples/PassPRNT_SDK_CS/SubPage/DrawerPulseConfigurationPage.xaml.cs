using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class DrawerPulseConfigurationPage : Page
    {
        string key = "drawerpulse";

        public DrawerPulseConfigurationPage()
        {
            this.InitializeComponent();
            DrawerPulsePreference.ItemsSource = Settings.DrawerPulsePreference;
            DrawerPulsePreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.DrawerPulsePreference.Count; i++)
            {
                string str = Settings.DrawerPulsePreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    DrawerPulsePreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void DrawerPulsePreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.DrawerPulsePreference[DrawerPulsePreference.SelectedIndex]);
            Settings.setValue(key, Settings.DrawerPulsePreference[DrawerPulsePreference.SelectedIndex]);
        }
    }
}