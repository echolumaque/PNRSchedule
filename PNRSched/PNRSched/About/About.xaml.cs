using Microsoft.AppCenter.Distribute;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace PNRSched
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About : ContentPage
    {
        public About()
        {
            InitializeComponent();
        }
        private void routePCKR_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (routePCKR.SelectedIndex == 0)
            {
                tutubanGPPCKR.IsEnabled = true;
                tutubanGPPCKR.IsVisible = true;

                gptutubanPCKR.IsEnabled = false;
                gptutubanPCKR.IsVisible = false;
                bicutangpPCKR.IsEnabled = false;
                bicutangpPCKR.IsVisible = false;
                gpbicutanPCKR.IsEnabled = false;
                gpbicutanPCKR.IsVisible = false;
            }
            if (routePCKR.SelectedIndex == 1)
            {
                gptutubanPCKR.IsEnabled = true;
                gptutubanPCKR.IsVisible = true;

                tutubanGPPCKR.IsEnabled = false;
                tutubanGPPCKR.IsVisible = false;
                bicutangpPCKR.IsEnabled = false;
                bicutangpPCKR.IsVisible = false;
                gpbicutanPCKR.IsEnabled = false;
                gpbicutanPCKR.IsVisible = false;

            }
            if (routePCKR.SelectedIndex == 2)
            {
                bicutangpPCKR.IsEnabled = true;
                bicutangpPCKR.IsVisible = true;

                tutubanGPPCKR.IsEnabled = false;
                tutubanGPPCKR.IsVisible = false;
                gptutubanPCKR.IsEnabled = false;
                gptutubanPCKR.IsVisible = false;
                gpbicutanPCKR.IsEnabled = false;
                gpbicutanPCKR.IsVisible = false;


            }
            if (routePCKR.SelectedIndex == 3)
            {
                gpbicutanPCKR.IsEnabled = true;
                gpbicutanPCKR.IsVisible = true;

                tutubanGPPCKR.IsEnabled = false;
                tutubanGPPCKR.IsVisible = false;
                gptutubanPCKR.IsEnabled = false;
                gptutubanPCKR.IsVisible = false;
                bicutangpPCKR.IsEnabled = false;
                bicutangpPCKR.IsVisible = false;

            }

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (routePCKR.SelectedIndex == 0) //TutubanGP
                {
                    string notify = string.Format("You will be notified when a train arrived at {0} in {1}'s route. Please re-set your desired train's schedule when you reboot your device.", tutubanGPPCKR.SelectedItem.ToString(), routePCKR.SelectedItem.ToString());
                    DisplayAlert("Notifications", notify.ToString(), "Okay");
                    if (tutubanGPPCKR.SelectedIndex == 0)
                    {
                        NotifClass.TutubanGPScheds.Tutuban();
                    }
                    if (tutubanGPPCKR.SelectedIndex == 1)
                    {
                        NotifClass.TutubanGPScheds.Solis();
                    }
                    if (tutubanGPPCKR.SelectedIndex == 2)
                    {
                        NotifClass.TutubanGPScheds.C3();
                    }
                    if (tutubanGPPCKR.SelectedIndex == 3)
                    {
                        NotifClass.TutubanGPScheds.Asistio();
                    }
                    if (tutubanGPPCKR.SelectedIndex == 4)
                    {
                        NotifClass.TutubanGPScheds.Sangandaan();
                    }
                    if (tutubanGPPCKR.SelectedIndex == 5)
                    {
                        NotifClass.TutubanGPScheds.GP();
                    }
                } //TutubanGP
                if (routePCKR.SelectedIndex == 1) //GPTutuban
                {
                    string notify = string.Format("You will be notified when a train arrived at {0} in {1}'s route. Please re-set your desired train's schedule when you reboot your device.", gptutubanPCKR.SelectedItem.ToString(), routePCKR.SelectedItem.ToString());
                    DisplayAlert("Notifications", notify.ToString(), "Okay");
                    if (gptutubanPCKR.SelectedIndex == 0)
                    {
                        NotifClass.GPTutubanScheds.Tutuban();
                    }
                    if (gptutubanPCKR.SelectedIndex == 1)
                    {
                        NotifClass.GPTutubanScheds.Solis();
                    }
                    if (gptutubanPCKR.SelectedIndex == 2)
                    {
                        NotifClass.GPTutubanScheds.C3();
                    }
                    if (gptutubanPCKR.SelectedIndex == 3)
                    {
                        NotifClass.GPTutubanScheds.Asistio();
                    }
                    if (gptutubanPCKR.SelectedIndex == 4)
                    {
                        NotifClass.GPTutubanScheds.Sangandaan();
                    }
                    if (gptutubanPCKR.SelectedIndex == 5)
                    {
                        NotifClass.GPTutubanScheds.GP();
                    }
                } //GPTutuban
                if (routePCKR.SelectedIndex == 2) //BicutanGP
                {
                    string notify = string.Format("You will be notified when a train arrived at {0} in {1}'s route. Please re-set your desired train's schedule when you reboot your device.", bicutangpPCKR.SelectedItem.ToString(), routePCKR.SelectedItem.ToString());
                    DisplayAlert("Notifications", notify.ToString(), "Okay");
                    if (bicutangpPCKR.SelectedIndex == 0)
                    {
                        NotifClass.BicutanGPScheds.Bicutan1();
                    }
                    if (bicutangpPCKR.SelectedIndex == 1)
                    {
                        NotifClass.BicutanGPScheds.FTI1();
                    }
                    if (bicutangpPCKR.SelectedIndex == 2)
                    {
                        NotifClass.BicutanGPScheds.Nichols1();
                    }
                    if (bicutangpPCKR.SelectedIndex == 3)
                    {
                        NotifClass.BicutanGPScheds.EDSA1();
                    }
                    if (bicutangpPCKR.SelectedIndex == 4)
                    {
                        NotifClass.BicutanGPScheds.PasayRoad();
                    }
                    if (bicutangpPCKR.SelectedIndex == 5)
                    {
                        NotifClass.BicutanGPScheds.DelaRosa();
                    }
                    if (bicutangpPCKR.SelectedIndex == 6)
                    {
                        NotifClass.BicutanGPScheds.VitoCruz();
                    }
                    if (bicutangpPCKR.SelectedIndex == 7)
                    {
                        NotifClass.BicutanGPScheds.SanAndres();
                    }
                    if (bicutangpPCKR.SelectedIndex == 8)
                    {
                        NotifClass.BicutanGPScheds.Paco();
                    }
                    if (bicutangpPCKR.SelectedIndex == 9)
                    {
                        NotifClass.BicutanGPScheds.Pandacan();
                    }
                    if (bicutangpPCKR.SelectedIndex == 10)
                    {
                        NotifClass.BicutanGPScheds.StaMesa();
                    }
                    if (bicutangpPCKR.SelectedIndex == 11)
                    {
                        NotifClass.BicutanGPScheds.Espana();
                    }
                    if (bicutangpPCKR.SelectedIndex == 12)
                    {
                        NotifClass.BicutanGPScheds.LaonLaan();
                    }
                    if (bicutangpPCKR.SelectedIndex == 13)
                    {
                        NotifClass.BicutanGPScheds.Blumentritt();
                    }
                    if (bicutangpPCKR.SelectedIndex == 14)
                    {
                        NotifClass.BicutanGPScheds.Solis();
                    }
                    if (bicutangpPCKR.SelectedIndex == 15)
                    {
                        NotifClass.BicutanGPScheds.C3();
                    }
                    if (bicutangpPCKR.SelectedIndex == 16)
                    {
                        NotifClass.BicutanGPScheds.Asistio();
                    }
                    if (bicutangpPCKR.SelectedIndex == 17)
                    {
                        NotifClass.BicutanGPScheds.Sangandaan();
                    }
                    if (bicutangpPCKR.SelectedIndex == 18)
                    {
                        NotifClass.BicutanGPScheds.GovernorPascual();
                    }
                } //BicutanGP
                if (routePCKR.SelectedIndex == 3) //GPBicutan
                {
                    string notify = string.Format("You will be notified when a train arrived at {0} in {1}'s route. Please re-set your desired train's schedule when you reboot your device.", gpbicutanPCKR.SelectedItem.ToString(), routePCKR.SelectedItem.ToString());
                    DisplayAlert("Notifications", notify.ToString(), "Okay");
                    if (gpbicutanPCKR.SelectedIndex == 0)
                    {
                        NotifClass.GPBicutanScheds.GovernorPascual();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 1)
                    {
                        NotifClass.GPBicutanScheds.Sangandaan();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 2)
                    {
                        NotifClass.GPBicutanScheds.Asistio();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 3)
                    {
                        NotifClass.GPBicutanScheds.C3();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 4)
                    {
                        NotifClass.GPBicutanScheds.Solis();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 5)
                    {
                        NotifClass.GPBicutanScheds.Blumentritt();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 6)
                    {
                        NotifClass.GPBicutanScheds.LaonLaan();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 7)
                    {
                        NotifClass.GPBicutanScheds.Espana();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 8)
                    {
                        NotifClass.GPBicutanScheds.StaMesa();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 9)
                    {
                        NotifClass.GPBicutanScheds.Pandacan();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 10)
                    {
                        NotifClass.GPBicutanScheds.Paco();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 11)
                    {
                        NotifClass.GPBicutanScheds.SanAndres();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 12)
                    {
                        NotifClass.GPBicutanScheds.VitoCruz();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 13)
                    {
                        NotifClass.GPBicutanScheds.DelaRosa();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 14)
                    {
                        NotifClass.GPBicutanScheds.PasayRoad();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 15)
                    {
                        NotifClass.GPBicutanScheds.EDSA2();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 16)
                    {
                        NotifClass.GPBicutanScheds.Nichols1();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 17)
                    {
                        NotifClass.GPBicutanScheds.FTI1();
                    }
                    if (gpbicutanPCKR.SelectedIndex == 18)
                    {
                        NotifClass.GPBicutanScheds.Bicutan1();
                    }
                } //GPBicutan
            }
            catch (Exception)
            {
                DisplayAlert("Notice", "Please fill both fields", "Okay");
            }
        }
        private async void CancelButton_Clicked_1(object sender, EventArgs e)
        {
            var ans = await DisplayAlert("Notice", "Are you sure you want to cancel notifications", "Yes", "No");
            if (ans == true)
            {
                DependencyService.Get<ILocalNotif>().CancelAlarm();
                await DisplayAlert("", "All notifications has been canceled", "Okay");
            }
            else
            {
                await DisplayAlert("", "You will continue receive notifactions when a train arrived at your station set", "Okay");
            }
        }
        private void Update_Clicked(object sender, EventArgs e)
        {
            Distribute.CheckForUpdate();
            DisplayAlert("", "You already installed the latest version", "Okay");

        }
        private void Contact_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.m.me/TataEchooo");
        }
    }
}
