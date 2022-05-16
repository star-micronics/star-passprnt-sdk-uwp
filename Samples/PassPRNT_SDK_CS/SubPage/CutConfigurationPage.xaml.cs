using System;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class CutConfigurationPage : Page
    {
        string key = "cut";

        public CutConfigurationPage()
        {
            this.InitializeComponent();
            CutPreference.ItemsSource = Settings.CutPreference;
            CutPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < Settings.CutPreference.Count; i++)
            {
                string str = Settings.CutPreference[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    CutPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void CutPreference_DropDownClosed(object sender, object e)
        {
            MyDebug.Console(Settings.CutPreference[CutPreference.SelectedIndex]);
            Settings.setValue(key, Settings.CutPreference[CutPreference.SelectedIndex]);
        }
    }
}