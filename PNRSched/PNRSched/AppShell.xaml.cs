using Xamarin.Essentials;
using Xamarin.Forms;

namespace PNRSched
{
    public partial class AppShell : Shell
    {

        public AppShell()
        {
            InitializeComponent();
            if (VersionTracking.IsFirstLaunchEver)
            {
                Navigation.PushModalAsync(new OnboardingPage());
            }
        }
    }
}