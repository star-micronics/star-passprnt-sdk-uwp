using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class DrawerConfigurationPage : Page
    {
        string key = "drawer";

        public DrawerConfigurationPage()
        {
            this.InitializeComponent();
            DrawerPreference.ItemsSource = Settings.DrawerPreference;
            DrawerPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.DrawerPreference.Count; i++)
            {
                string str = Settings.DrawerPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    DrawerPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void DrawerPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.DrawerPreference[DrawerPreference.SelectedIndex]);
            Settings.setValue(key, Settings.DrawerPreference[DrawerPreference.SelectedIndex]);
        }
    }
}
