using System;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PassPRNT_SDK_CS.SubPage
{
    public sealed partial class RunPrintPage : Page
    {
        private StringBuilder urlScheme = new StringBuilder("starpassprnt://v1/print/nopreview?");

        public RunPrintPage()
        {
            this.InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            await createUrlScheme();
            tbUri.Text = urlScheme.ToString();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // NOTE : Windows OS Limitation
            // URI Scheme has a limitation 100K byte as passing data length
            // Host application should control data length less than 100 Byte
            // More Information below:
            // https://msdn.microsoft.com/en-us/library/windows/apps/dn934792.aspx
            MyDebug.Console("Total : " + urlScheme.ToString().Length + "byte(s)");
            MyDebug.Console(urlScheme.Length.ToString());

            var uri = new Uri(urlScheme.ToString());

            // Launch the URI.
            bool success = await Launcher.LaunchUriAsync(uri);
            if (success)
            {
                MyDebug.Console("URI launched: " + uri.AbsoluteUri);
            }
            else
            {
                MyDebug.Console("URI launch failed: " + uri.AbsoluteUri);
            }
        }

        private async Task createUrlScheme()
        {
            //string urlScheme = "starpassprnt://v1/print/nopreview?";
            urlScheme = new StringBuilder("starpassprnt://v1/print/nopreview?");

            string port             = (string)Settings.getValue("port");
            string settings         = (string)Settings.getValue("settings");
            string timeout          = (string)Settings.getValue("timeout");
            string size             = (string)Settings.getValue("size");
            string drawer           = (string)Settings.getValue("drawer");
            string drawerpulse      = (string)Settings.getValue("drawerpulse");
            string buzzer           = (string)Settings.getValue("buzzer");
            string buzzerchannel    = (string)Settings.getValue("buzzerchannel");
            string buzzerrepeat     = (string)Settings.getValue("buzzerrepeat");
            string buzzerdrivetime  = (string)Settings.getValue("buzzerdrivetime");
            string buzzerdelaytime  = (string)Settings.getValue("buzzerdelaytime");
            string sound            = (string)Settings.getValue("sound");
            string soundstoragearea = (string)Settings.getValue("soundstoragearea");
            string soundnumber      = (string)Settings.getValue("soundnumber");
            string soundvolume      = (string)Settings.getValue("soundvolume");
            string back             = (string)Settings.getValue("back");
            string blackmark        = (string)Settings.getValue("blackmark");
            string cut              = (string)Settings.getValue("cut");
            string popup            = (string)Settings.getValue("popup");
            string html             = (string)Settings.getValue("html");
            string url              = (string)Settings.getValue("url");

            if (!port.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("port=");
                urlScheme.Append(ConfigureQueryValue(port, true));
                urlScheme.Append("&");
            }
            if (!settings.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("settings=");
                if (!settings.Equals("blank", StringComparison.CurrentCultureIgnoreCase))
                {
                    urlScheme.Append(ConfigureQueryValue(settings, true));
                }
                urlScheme.Append("&");
            }
            if (!timeout.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("timeout=");
                urlScheme.Append(ConfigureQueryValue(timeout, false));
                urlScheme.Append("&");
            }
            if (!size.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("size=");
                urlScheme.Append(ConfigureQueryValue(size, false));
                urlScheme.Append("&");
            }
            if (!drawer.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("drawer=");
                urlScheme.Append(ConfigureQueryValue(drawer, false));
                urlScheme.Append("&");
            }
            if (!drawerpulse.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("drawerpulse=");
                urlScheme.Append(ConfigureQueryValue(drawerpulse, false));
                urlScheme.Append("&");
            }
            if (!buzzer.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("buzzer=");
                urlScheme.Append(ConfigureQueryValue(buzzer, false));
                urlScheme.Append("&");
            }
            if (!buzzerchannel.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("buzzerchannel=");
                urlScheme.Append(ConfigureQueryValue(buzzerchannel, false));
                urlScheme.Append("&");
            }
            if (!buzzerrepeat.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("buzzerrepeat=");
                urlScheme.Append(ConfigureQueryValue(buzzerrepeat, false));
                urlScheme.Append("&");
            }
            if (!buzzerdrivetime.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("buzzerdrivetime=");
                urlScheme.Append(ConfigureQueryValue(buzzerdrivetime, false));
                urlScheme.Append("&");
            }
            if (!buzzerdelaytime.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("buzzerdelaytime=");
                urlScheme.Append(ConfigureQueryValue(buzzerdelaytime, false));
                urlScheme.Append("&");
            }
            if (!sound.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("sound=");
                urlScheme.Append(ConfigureQueryValue(sound, false));
                urlScheme.Append("&");
            }
            if (!soundstoragearea.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("soundstoragearea=");
                urlScheme.Append(ConfigureQueryValue(soundstoragearea, false));
                urlScheme.Append("&");
            }
            if (!soundnumber.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("soundnumber=");
                urlScheme.Append(ConfigureQueryValue(soundnumber, false));
                urlScheme.Append("&");
            }
            if (!soundvolume.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("soundvolume=");
                urlScheme.Append(ConfigureQueryValue(soundvolume, false));
                urlScheme.Append("&");
            }
            if (!back.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("back=");
                urlScheme.Append(ConfigureQueryValue(back, true));
                urlScheme.Append("&");
            }
            if (!blackmark.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("blackmark=");
                urlScheme.Append(ConfigureQueryValue(blackmark, true));
                urlScheme.Append("&");
            }
            if (!cut.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("cut=");
                urlScheme.Append(ConfigureQueryValue(cut, true));
                urlScheme.Append("&");
            }
            if (!popup.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("popup=");
                urlScheme.Append(ConfigureQueryValue(popup, true));
                urlScheme.Append("&");
            }
            if (!html.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("html=");
                urlScheme.Append(ConfigureQueryValue(await LoadDataFromLocalFile(html), true));
                urlScheme.Append("&");
            }
            if (!url.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                urlScheme.Append("url=");
                urlScheme.Append(ConfigureQueryValue(url, true));
                urlScheme.Append("&");
            }
        }

        private string ConfigureQueryValue(string value, bool encode)
        {
            string str = null;

            if (!value.Equals("none", StringComparison.CurrentCultureIgnoreCase))
            {
                if (!value.Equals("blank", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (encode)
                    {
                        str = UriManager.UriEncode(value);
                        MyDebug.Console(str.Length.ToString());
                    }
                    else
                    {
                        str = value;
                    }
                }
                else
                {
                    str = string.Empty;
                }
            }

            return str;
        }

        private async Task<string> LoadDataFromLocalFile(string file)
        {
            return await AssetFolderManager.LoadFileData(file);
        }
    }
}
