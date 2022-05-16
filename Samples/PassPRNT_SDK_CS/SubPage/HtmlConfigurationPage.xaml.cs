using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class HtmlConfigurationPage : Page
    {
        string key = "html";
        List<string> htmlFiles = new List<string>();

        public HtmlConfigurationPage()
        {
            this.InitializeComponent();
            this.InitialAssetFiles();
        }

        private async void InitialAssetFiles()
        {
            htmlFiles.AddRange(Settings.HtmlPreference);
            htmlFiles.AddRange(await AssetFolderManager.GetFileList("html"));

            HtmlPreference.ItemsSource = htmlFiles;
            HtmlPreference.SelectedIndex = 0;

            string value = (string)Settings.getValue(key);

            for (int i = 0; i < htmlFiles.Count; i++)
            {
                string str = htmlFiles[i];

                if (String.Equals(value, str, StringComparison.CurrentCultureIgnoreCase))
                {
                    HtmlPreference.SelectedIndex = i;
                    break;
                }
            }
        }

        private void HtmlPreference_DropDownClosed(object sender, object e)
        {
            if (htmlFiles.Count > 0)
            {
                MyDebug.Console(htmlFiles[HtmlPreference.SelectedIndex]);
                Settings.setValue(key, htmlFiles[HtmlPreference.SelectedIndex]);
            }
        }
    }
}
