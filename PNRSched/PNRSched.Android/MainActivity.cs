using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.OS;
using XLabs.Ioc;
using XLabs.Platform.Device;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Distribute;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace PNRSched.Droid
{
    [Activity(Label = "Trainify", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);

            AppCenter.Start("db0361e2-b95f-43bc-beea-fc0960d9d621", typeof(Analytics), typeof(Crashes), typeof(Distribute)); //appcenter
            Analytics.TrackEvent("GradientButton_Clicked");

            var container = new SimpleContainer(); //xlabs
            container.Register(t => AndroidDevice.CurrentDevice);
            Resolver.ResetResolver();
            Resolver.SetResolver(container.GetResolver());

            Xamarin.Forms.Forms.SetFlags(new string[] { "IndicatorView_Experimental", "Expander_Experimental" }); //experimentals

            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Xamarin.Forms.FormsMaterial.Init(this, savedInstanceState); //material

            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer: true); //image

            if (Build.VERSION.SdkInt >= BuildVersionCodes.P)
            {
                Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
                Window.Attributes.LayoutInDisplayCutoutMode = LayoutInDisplayCutoutMode.ShortEdges;
                Window.AddFlags(WindowManagerFlags.ForceNotFullscreen);
                Window.AddFlags(WindowManagerFlags.LayoutInOverscan);
                Window.ClearFlags(WindowManagerFlags.Fullscreen);
            }
            else
            {
                
            }
            LoadApplication(new App());
        }
    }
}