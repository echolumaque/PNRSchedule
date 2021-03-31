using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;
using XLabs.Platform.Device;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PNRSched
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            LoadStyles();
        }

        void LoadStyles()
        {
            if (IsASmallDevice())
            { 
                dictionary.MergedDictionaries.Add(SmallDevicesStyle.SharedInstance);
            }
            else
            {
                dictionary.MergedDictionaries.Add(GeneralDevicesStyle.SharedInstance);
            }
        }
        
        public static bool IsASmallDevice()
        {
            var device = Resolver.Resolve<IDevice>();
            var display = device.Display;
            var ydpi = display.Ydpi;
            const int smallydpi = 420;
            return (ydpi < smallydpi);
        }
        protected override void OnStart()
        {
            VersionTracking.Track();
            AppCenter.Start("db0361e2-b95f-43bc-beea-fc0960d9d621", typeof(Analytics), typeof(Crashes), typeof(Distribute));
            Analytics.TrackEvent("GradientButton_Clicked");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
