using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.Foundation;
using Windows.UI.Xaml;
using PassPRNT_SDK_CS.SubPage;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Activation;

namespace PassPRNT_SDK_CS
{
    public partial class App : Application
    {
        protected override async void OnActivated(IActivatedEventArgs args)
        {
            base.OnActivated(args);

            if (args.Kind == ActivationKind.Protocol)
            {
                Frame rootFrame = CreateRootFrame();

                if (rootFrame.Content == null)
                {
                    if (!rootFrame.Navigate(typeof(MainPage)))
                    {
                        throw new Exception("Failed to create initial page");
                    }
                }

                var e = args as ProtocolActivatedEventArgs;

                try
                {
                    ContentDialog displayDialog = new ContentDialog()
                    {
                        Title = "Information",
                        Content = e.Uri.AbsoluteUri,
                        PrimaryButtonText = "OK"
                    };

                    ContentDialogResult result = await displayDialog.ShowAsync();
                }
                catch (Exception)
                {

                }

                var p = rootFrame.Content as MainPage;
                p.NavigateToPageWithParameter(0, args);

                Window.Current.Activate();
            }
        }
    }

    public partial class MainPage : Page
    {
        public const string INITIAL_TITLE = "Star PassPRNT SDK C# Sample";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title = Settings.QueryKeys[0],     ClassType = typeof(PortConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[1],     ClassType = typeof(SettingsConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[2],     ClassType = typeof(TimeoutConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[3],     ClassType = typeof(SizeConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[4],     ClassType = typeof(DrawerConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[5],     ClassType = typeof(DrawerPulseConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[6],     ClassType = typeof(BuzzerConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[7],     ClassType = typeof(BuzzerChannelConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[8],     ClassType = typeof(BuzzerRepeatConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[9],     ClassType = typeof(BuzzerDriveTimeConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[10],    ClassType = typeof(BuzzerDelayTimeConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[11],    ClassType = typeof(SoundConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[12],    ClassType = typeof(SoundStorageAreaConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[13],    ClassType = typeof(SoundNumberConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[14],    ClassType = typeof(SoundVolumeConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[15],    ClassType = typeof(BackConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[16],    ClassType = typeof(BlackMarkConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[17],    ClassType = typeof(CutConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[18],    ClassType = typeof(PopupConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[19],    ClassType = typeof(HtmlConfigurationPage) },
            new Scenario() { Title = Settings.QueryKeys[20],    ClassType = typeof(UrlConfigurationPage) },
            new Scenario() { Title = "Print",                   ClassType = typeof(RunPrintPage) },
        };

        public void NavigateToPageWithParameter(int pageIndex, object parameter)
        {
            ScenarioControl.SelectedIndex = pageIndex;
            ScenarioFrame.Navigate(scenarios[pageIndex].ClassType, parameter);
        }

        static public Point GetElementLocation(object e)
        {
            var element = (FrameworkElement)e;
            Windows.UI.Xaml.Media.GeneralTransform buttonTransform = element.TransformToVisual(null);

            Point desiredLocation = buttonTransform.TransformPoint(new Point());
            desiredLocation.Y = desiredLocation.Y + element.ActualHeight;

            return desiredLocation;
        }
    }

    public class Scenario
    {
        public string Title { get; set; }

        public Type ClassType { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }

    public class Settings
    {
        static public List<string> QueryKeys = new List<string>
        {
            "port",
            "settings",
            "timeout",
            "size",
            "drawer",
            "drawerpulse",
            "buzzer",
            "buzzerchannel",
            "buzzerrepeat",
            "buzzerdrivetime",
            "buzzerdelaytime",
            "sound",
            "soundstoragearea",
            "soundnumber",
            "soundvolume",
            "back",
            "blackmark",
            "cut",
            "popup",
            "html",
            "url",
        };

        static public List<String> PortPreference = new List<string>
        {
            "none",
            "bt:",
            "tcp:",//"tcp:xxx.xxx.xxx.xxx",  //Please type correct IP address
        };

        static public List<string> SettingsPreference = new List<string>
        {
            "none",
            "blank",
            "portable;",
            "portable;escpos",
            "escpos;",
        };

        static public List<String> TimeoutPreference = new List<string>
        {
            "none",
            "10000",
        };

        static public List<String> SizePreference = new List<string>
        {
            "none",
            "2",
            "2w1",
            "2w2",
            "2w3",
            "2w4",
            "3",
            "3w",
            "3w2",
            "4",
        };

        static public List<String> DrawerPreference = new List<String>
        {
            "none",
            "off",
            "ahead",
            "after",
        };

        static public List<String> DrawerPulsePreference = new List<String>
        {
            "none",
            "200",
            "500",
        };

        static public List<String> BuzzerPreference = new List<String>
        {
            "none",
            "off",
            "ahead",
            "after",
        };

        static public List<String> BuzzerChannelPreference = new List<String>
        {
            "none",
            "channel1",
            "channel2",
        };

        static public List<String> BuzzerRepeatPreference = new List<String>
        {
            "none",
            "1",
            "2",
            "5",
        };

        static public List<String> BuzzerDriveTimePreference = new List<String>
        {
            "none",
            "200",
            "500",
            "1000",
        };

        static public List<String> BuzzerDelayTimePreference = new List<String>
        {
            "none",
            "200",
            "500",
            "1000",
        };

        static public List<String> SoundPreference = new List<String>
        {
            "none",
            "off",
            "ahead",
            "after",
        };

        static public List<String> SoundStorageAreaPreference = new List<String>
        {
            "none",
            "area1",
            "area2",
        };

        static public List<String> SoundNumberPreference = new List<String>
        {
            "none",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
        };

        static public List<String> SoundVolumePreference = new List<String>
        {
            "none",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "off",
            "min",
            "max"
        };

        static public List<string> HtmlPreference = new List<string>
        {
            "none",
        };

        static public List<string> UrlPreference = new List<string>
        {
            "none",
            "https://www.star-m.jp/products/s_print/sdk/passprnt/sample/resource/receipt_sample.html",
            "https://www.star-m.jp/products/s_print/sdk/passprnt/sample/resource/receipt_sample.pdf",
        };

        static public List<String> PopupPreference = new List<string>
        {
            "none",
            "enable",
            "disable",
        };

        static public List<String> BlackmarkPreference = new List<string>
        {
            "none",
            "disable",
            "enable",
            "enableAndDetectAtPowerOn",
        };

        static public List<string> CutPreference = new List<string>
        {
            "none",
            "partial",
            "full",
            "tearbar",
            "nocut",
        };

        static public List<String> BackPreference = new List<string>
        {
            "passprntsdk://a/b",
        };

        static public void setValue(string key, object value)
        {
            object obj;
            if (CoreApplication.Properties.TryGetValue(key, out obj))
            {
                CoreApplication.Properties.Remove(key);
            }

            CoreApplication.Properties.Add(key, value);
        }

        static public object getValue(string key)
        {
            object obj;
            CoreApplication.Properties.TryGetValue(key, out obj);

            return obj != null ? obj : null;
        }

        static public void Initialize()
        {
            for (int i = 0; i < Settings.QueryKeys.Count; i++)
            {
                if (getValue(QueryKeys[i]) == null)
                {
                    if (QueryKeys[i].ToString().Equals("back"))
                    {
                        setValue(QueryKeys[i], Settings.BackPreference[0]);
                    }
                    else
                    {
                        setValue(QueryKeys[i], "none");
                    }
                }
            }
        }
    }
}
