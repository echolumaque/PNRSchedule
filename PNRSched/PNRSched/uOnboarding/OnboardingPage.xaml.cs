using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PNRSched
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnboardingPage : ContentPage
    {
        public OnboardingPage()
        {
            InitializeComponent();
        }       
        private void mainCAROUSEL_PositionChanged_1(object sender, PositionChangedEventArgs e)
        {
            button.IsVisible = true;
        }
    }
}