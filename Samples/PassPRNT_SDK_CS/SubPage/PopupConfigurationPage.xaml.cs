using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class PopupConfigurationPage : Page
    {
        string key = "popup";

        public PopupConfigurationPage()
        {
            this.InitializeComponent();
            PopupPreference.ItemsSource = Settings.PopupPreference;
            PopupPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.PopupPreference.Count; i++)
            {
                string str = Settings.PopupPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    PopupPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void PopupPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.PopupPreference[PopupPreference.SelectedIndex]);
            Settings.setValue(key, Settings.PopupPreference[PopupPreference.SelectedIndex]);
        }
    }
}
