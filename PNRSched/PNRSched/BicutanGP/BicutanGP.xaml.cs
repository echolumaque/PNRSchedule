using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;
using XLabs.Platform.Device;

namespace PNRSched
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GPBicutan : ContentPage
	{
        readonly TrainNumberGPBIC tno1 = new TrainNumberGPBIC();
        readonly Bicutan1 bic = new Bicutan1();
        readonly FTI1 fti = new FTI1();
        readonly NIC1 nic = new NIC1();
        readonly EDSA1 edsa = new EDSA1();
        readonly PASAYROAD1 pasay = new PASAYROAD1();
        readonly DELAROSA1 delarosa = new DELAROSA1();
        readonly VITOCRUZ1 vitocruz = new VITOCRUZ1();
        readonly SANADNRES1 sanandres = new SANADNRES1();
        readonly PACO1 paco = new PACO1();
        readonly PANDACAN1 pandacan = new PANDACAN1();
        readonly STAMESA1 stamesa = new STAMESA1();
        readonly ESPANA1 espana = new ESPANA1();
        readonly LAONLAAN1 laonlaan = new LAONLAAN1();
        readonly BLUM1 blum = new BLUM1();
        readonly SOLIS1 solis = new SOLIS1();
        readonly C31 c3 = new C31();
        readonly ASISTIO1 ass = new ASISTIO1();
        readonly SDAAN1 sdaan = new SDAAN1();
        readonly GP1 gp = new GP1();
        public GPBicutan ()
		{
			InitializeComponent ();
            Shell.SetNavBarIsVisible(this, false);
            bottomSheet.IsVisible = false;
            timePCKR.Time = DateTime.Now.TimeOfDay;
            timePCKR.Format = "hh:mm tt";

            var device = Resolver.Resolve<IDevice>();
            var display = device.Display;
            var ydpi = display.Ydpi;
            const int smallydpi = 420;
            if (ydpi >= smallydpi)
            {
                labelHEAD.FontSize = 50;
            }
            if (ydpi < smallydpi)
            {
                labelHEAD.FontSize = 30;
            }
        }
        private void entryTIME1_Focused(object sender, FocusEventArgs e)
        {
            timePCKR.Focus();
            entryTIME1.IsEnabled = false;
            entryTIME1.IsVisible = false;
            timePCKR.IsVisible = true;
            timePCKR.IsEnabled = true;
            timePCKR.Format = "hh:mm tt";
        }
        private  void GradientButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getProportionCoordinate(.80))); //bago, pang animate pag button clock
                bottomSheet.TranslateTo(bottomSheet.X, finalTranslation, 500, Easing.CubicInOut);
                TrainNumber();
                bottomSheet.IsVisible = true;
                labelORIG.Text = pckrORIGIN.SelectedItem.ToString();
                labelDEST.Text = pckrDEST.SelectedItem.ToString();
                var time1 = DateTime.Parse(firstDEST.Text).Subtract(DateTime.Parse(firstORIG.Text)).Hours.ToString();
                var time2 = DateTime.Parse(firstDEST.Text).Subtract(DateTime.Parse(firstORIG.Text)).Minutes.ToString();

                labelDURATION.Text = string.Format("{0} hr {1} mins", time1, time2);

                if (pckrORIGIN.SelectedIndex == 0)
                {
                    int res1 = DateTime.Parse(bic.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(bic.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(bic.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(bic.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(bic.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(bic.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(bic.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(bic.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", bic.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", bic.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", bic.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", bic.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", bic.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", bic.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", bic.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", bic.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 1)
                {
                    int res1 = DateTime.Parse(fti.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(fti.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(fti.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(fti.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(fti.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(fti.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(fti.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(fti.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", fti.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", fti.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", fti.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", fti.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", fti.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", fti.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", fti.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", fti.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 2)
                {
                    int res1 = DateTime.Parse(nic.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(nic.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(nic.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(nic.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(nic.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(nic.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(nic.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(nic.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", nic.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", nic.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", nic.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", nic.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", nic.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", nic.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", nic.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", nic.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 3)
                {
                    int res1 = DateTime.Parse(edsa.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(edsa.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(edsa.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(edsa.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(edsa.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(edsa.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(edsa.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(edsa.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", edsa.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", edsa.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", edsa.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", edsa.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", edsa.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", edsa.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", edsa.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", edsa.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 4)
                {
                    int res1 = DateTime.Parse(pasay.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(pasay.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(pasay.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(pasay.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(pasay.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(pasay.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(pasay.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(pasay.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pasay.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pasay.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pasay.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pasay.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pasay.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pasay.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pasay.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pasay.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 5)
                {
                    int res1 = DateTime.Parse(delarosa.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(delarosa.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(delarosa.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(delarosa.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(delarosa.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(delarosa.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(delarosa.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(delarosa.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", delarosa.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", delarosa.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", delarosa.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", delarosa.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", delarosa.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", delarosa.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", delarosa.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", delarosa.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 6)
                {
                    int res1 = DateTime.Parse(vitocruz.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(vitocruz.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(vitocruz.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(vitocruz.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(vitocruz.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(vitocruz.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(vitocruz.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(vitocruz.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", vitocruz.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", vitocruz.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", vitocruz.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", vitocruz.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", vitocruz.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", vitocruz.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", vitocruz.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", vitocruz.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 7)
                {
                    int res1 = DateTime.Parse(sanandres.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(sanandres.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(sanandres.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(sanandres.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(sanandres.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(sanandres.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(sanandres.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(sanandres.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sanandres.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sanandres.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sanandres.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sanandres.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sanandres.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sanandres.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sanandres.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sanandres.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 8)
                {
                    int res1 = DateTime.Parse(paco.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(paco.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(paco.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(paco.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(paco.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(paco.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(paco.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(paco.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", paco.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", paco.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", paco.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", paco.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", paco.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", paco.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", paco.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", paco.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 9)
                {
                    int res1 = DateTime.Parse(pandacan.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(pandacan.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(pandacan.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(pandacan.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(pandacan.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(pandacan.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(pandacan.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(pandacan.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pandacan.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pandacan.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pandacan.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pandacan.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pandacan.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pandacan.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pandacan.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", pandacan.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 10)
                {
                    int res1 = DateTime.Parse(stamesa.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(stamesa.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(stamesa.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(stamesa.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(stamesa.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(stamesa.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(stamesa.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(stamesa.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", stamesa.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", stamesa.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", stamesa.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", stamesa.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", stamesa.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", stamesa.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", stamesa.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", stamesa.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 11)
                {
                    int res1 = DateTime.Parse(espana.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(espana.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(espana.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(espana.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(espana.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(espana.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(espana.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(espana.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", espana.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", espana.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", espana.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", espana.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", espana.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", espana.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", espana.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", espana.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 12)
                {
                    int res1 = DateTime.Parse(laonlaan.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(laonlaan.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(laonlaan.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(laonlaan.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(laonlaan.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(laonlaan.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(laonlaan.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(laonlaan.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", laonlaan.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", laonlaan.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", laonlaan.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", laonlaan.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", laonlaan.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", laonlaan.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", laonlaan.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", laonlaan.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 13)
                {
                    int res1 = DateTime.Parse(blum.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(blum.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(blum.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(blum.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(blum.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(blum.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(blum.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(blum.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", blum.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", blum.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", blum.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", blum.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", blum.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", blum.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", blum.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", blum.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 14)
                {
                    int res1 = DateTime.Parse(solis.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(solis.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(solis.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(solis.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(solis.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(solis.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(solis.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(solis.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", solis.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", solis.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", solis.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", solis.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", solis.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", solis.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", solis.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", solis.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 15)
                {
                    int res1 = DateTime.Parse(c3.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(c3.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(c3.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(c3.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(c3.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(c3.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(c3.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(c3.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", c3.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", c3.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", c3.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", c3.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", c3.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", c3.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", c3.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", c3.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 16)
                {
                    int res1 = DateTime.Parse(ass.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(ass.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(ass.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(ass.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(ass.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(ass.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(ass.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(ass.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", ass.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", ass.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", ass.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", ass.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", ass.sched5.ToString());

                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", ass.sched6.ToString());

                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", ass.sched7.ToString());

                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", ass.sched8.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 17)
                {
                    int res1 = DateTime.Parse(sdaan.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(sdaan.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(sdaan.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(sdaan.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(sdaan.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(sdaan.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(sdaan.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(sdaan.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sdaan.sched1.ToString());
                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sdaan.sched2.ToString());
                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sdaan.sched3.ToString());
                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sdaan.sched4.ToString());
                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sdaan.sched5.ToString());
                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sdaan.sched6.ToString());
                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sdaan.sched7.ToString());
                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sdaan.sched8.ToString());
                    }
                }
                if (pckrORIGIN.SelectedIndex == 18)
                {
                    int res1 = DateTime.Parse(gp.sched1).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res2 = DateTime.Parse(gp.sched2).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res3 = DateTime.Parse(gp.sched3).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res4 = DateTime.Parse(gp.sched4).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res5 = DateTime.Parse(gp.sched5).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res6 = DateTime.Parse(gp.sched6).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res7 = DateTime.Parse(gp.sched7).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    int res8 = DateTime.Parse(gp.sched8).CompareTo(DateTime.Parse(timePCKR.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", gp.sched1.ToString());
                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", gp.sched2.ToString());
                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", gp.sched3.ToString());
                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", gp.sched4.ToString());
                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", gp.sched5.ToString());
                    }
                    else if (res6 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", gp.sched6.ToString());
                    }
                    else if (res7 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", gp.sched7.ToString());
                    }
                    else if (res8 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", gp.sched8.ToString());
                    }
                }
                TrainLoc();
            }
            catch (Exception)
            {
                bottomSheet.IsVisible = false;
                pckrORIGIN.SelectedIndex = -1;
                pckrDEST.SelectedIndex = -1;
                entryTIME1.IsEnabled = true;
                entryTIME1.IsVisible = true;
                timePCKR.IsVisible = false;
                timePCKR.IsEnabled = false;
                DisplayAlert("Notice", "Please fill up the FROM, TO, and WHEN fields in their respective order before pressing the view schedule button", "Okay");
            }
        }
        private void timePCKR_Focused(object sender, FocusEventArgs e)
        {
            try
            {
                if (pckrORIGIN.SelectedIndex == 0)
                {
                    SView();
                    BICOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 1)
                {
                    SView();
                    FTIOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 2)
                {
                    SView();
                    NICOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 3)
                {
                    SView();
                    EDSAOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 4)
                {
                    SView();
                    PASAYOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 5)
                {
                    SView();
                    DELAROSAOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 6)//6th
                {
                    SView();
                    VITOCRUZOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 7)
                {
                    SView();
                    SANANDRESOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 8)
                {
                    SView();
                    PACOOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 9)
                {
                    SView();
                    PANDACANOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 10)
                {
                    SView();
                    STAMESAOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 11)
                {
                    SView();
                    ESPANAOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 12)
                {
                    SView();
                    LAONLAANOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 13)
                {
                    SView();
                    BLUMOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 14)
                {
                    SView();
                    SOLISOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 15)
                {
                    SView();
                    C31Origin();
                }
                if (pckrORIGIN.SelectedIndex == 16)
                {
                    SView();
                    ASISTIOOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 17)
                {
                    SView();
                    SDAANOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 18)
                {
                    SView();
                    GPOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 18 && pckrDEST.SelectedIndex == 18)
                {
                    GPOrigin();
                    GPDest();
                }

                if (pckrDEST.SelectedIndex == 0)
                {
                    SView();
                    BICDest();
                }
                if (pckrDEST.SelectedIndex == 1)
                {
                    SView();
                    FTIDest();
                }
                if (pckrDEST.SelectedIndex == 2)
                {
                    SView();
                    NICDest();
                }
                if (pckrDEST.SelectedIndex == 3)
                {
                    SView();
                    EDSADest();
                }
                if (pckrDEST.SelectedIndex == 4)
                {
                    SView();
                    PASAYDest();
                }
                if (pckrDEST.SelectedIndex == 5)
                {
                    SView();
                    DELAROSADest();
                }
                if (pckrDEST.SelectedIndex == 6)//6th
                {
                    SView();
                    VITOCRUZDest();
                }
                if (pckrDEST.SelectedIndex == 7)
                {
                    SView();
                    SANANDRESDest();
                }
                if (pckrDEST.SelectedIndex == 8)
                {
                    SView();
                    PACODest();
                }
                if (pckrDEST.SelectedIndex == 9)
                {
                    SView();
                    PANDACANDest();
                }
                if (pckrDEST.SelectedIndex == 10)
                {
                    SView();
                    STAMESADest();
                }
                if (pckrDEST.SelectedIndex == 11)
                {
                    SView();
                    ESPANADest();
                }
                if (pckrDEST.SelectedIndex == 12)
                {
                    SView();
                    LAONLAANDest();
                }
                if (pckrDEST.SelectedIndex == 13)
                {
                    SView();
                    BLUMDest();
                }
                if (pckrDEST.SelectedIndex == 14)
                {
                    SView();
                    SOLISDest();
                }
                if (pckrDEST.SelectedIndex == 15)
                {
                    SView();
                    C31Dest();
                }
                if (pckrDEST.SelectedIndex == 16)
                {
                    SView();
                    ASISTIODest();
                }
                if (pckrDEST.SelectedIndex == 17)
                {
                    SView();
                    SDAANDest();
                }
                if (pckrDEST.SelectedIndex == 18)
                {
                    SView();
                    GPDest();
                }
                if (pckrORIGIN.SelectedIndex > pckrDEST.SelectedIndex)
                {
                    sview1.IsVisible = false;
                    DisplayAlert("Notice", "Backward route is not possible. Please consider going to GOV. PASCUAL - TUTUBAN tab or other tab. You may re-enter routes for schedules.", "Okay");
                }
            }
            catch (Exception)
            {
                DisplayAlert("Notice", "Please fill up the origin/destination/time fields", "Okay");
            }
        }
        public double getProportionCoordinate(double proportion)
        {
            return proportion * Height;
        } //bago
        public bool isSwipeUp(PanUpdatedEventArgs e)
        {
            if (e.TotalY < 0)
            {
                return true;
            }
            return false;
        }
        void BICOrigin()
        {
            firstORIG.Text = bic.sched1;
            secondORIG.Text = bic.sched2;
            thirdORIG.Text = bic.sched3;
            fourthORIG.Text = bic.sched4;
            fifthORIG.Text = bic.sched5;
            sixthORIG.Text = bic.sched6;
            seventhORIG.Text = bic.sched7;
            eighthORIG.Text = bic.sched8;
        }
        void NICOrigin()
        {
            firstORIG.Text = nic.sched1;
            secondORIG.Text = nic.sched2;
            thirdORIG.Text = nic.sched3;
            fourthORIG.Text = nic.sched4;
            fifthORIG.Text = nic.sched5;
            sixthORIG.Text = nic.sched6;
            seventhORIG.Text = nic.sched7;
            eighthORIG.Text = nic.sched8;
        }
        void FTIOrigin()
        {
            firstORIG.Text = fti.sched1;
            secondORIG.Text = fti.sched2;
            thirdORIG.Text = fti.sched3;
            fourthORIG.Text = fti.sched4;
            fifthORIG.Text = fti.sched5;
            sixthORIG.Text = fti.sched6;
            seventhORIG.Text = fti.sched7;
            eighthORIG.Text = fti.sched8;
        }
        void EDSAOrigin()
        {
            firstORIG.Text = edsa.sched1;
            secondORIG.Text = edsa.sched2;
            thirdORIG.Text = edsa.sched3;
            fourthORIG.Text = edsa.sched4;
            fifthORIG.Text = edsa.sched5;
            sixthORIG.Text = edsa.sched6;
            seventhORIG.Text = edsa.sched7;
            eighthORIG.Text = edsa.sched8;
        }
        void PASAYOrigin()
        {
            firstORIG.Text = pasay.sched1;
            secondORIG.Text = pasay.sched2;
            thirdORIG.Text = pasay.sched3;
            fourthORIG.Text = pasay.sched4;
            fifthORIG.Text = pasay.sched5;
            sixthORIG.Text = pasay.sched6;
            seventhORIG.Text = pasay.sched7;
            eighthORIG.Text = pasay.sched8;
        }
        void DELAROSAOrigin()
        {
            firstORIG.Text = delarosa.sched1;
            secondORIG.Text = delarosa.sched2;
            thirdORIG.Text = delarosa.sched3;
            fourthORIG.Text = delarosa.sched4;
            fifthORIG.Text = delarosa.sched5;
            sixthORIG.Text = delarosa.sched6;
            seventhORIG.Text = delarosa.sched7;
            eighthORIG.Text = delarosa.sched8;
        }
        void VITOCRUZOrigin()
        {
            firstORIG.Text = vitocruz.sched1;
            secondORIG.Text = vitocruz.sched2;
            thirdORIG.Text = vitocruz.sched3;
            fourthORIG.Text = vitocruz.sched4;
            fifthORIG.Text = vitocruz.sched5;
            sixthORIG.Text = vitocruz.sched6;
            seventhORIG.Text = vitocruz.sched7;
            eighthORIG.Text = vitocruz.sched8;
        }
        void SANANDRESOrigin()
        {
            firstORIG.Text = sanandres.sched1;
            secondORIG.Text = sanandres.sched2;
            thirdORIG.Text = sanandres.sched3;
            fourthORIG.Text = sanandres.sched4;
            fifthORIG.Text = sanandres.sched5;
            sixthORIG.Text = sanandres.sched6;
            seventhORIG.Text = sanandres.sched7;
            eighthORIG.Text = sanandres.sched8;
        }
        void PACOOrigin()
        {
            firstORIG.Text = paco.sched1;
            secondORIG.Text = paco.sched2;
            thirdORIG.Text = paco.sched3;
            fourthORIG.Text = paco.sched4;
            fifthORIG.Text = paco.sched5;
            sixthORIG.Text = paco.sched6;
            seventhORIG.Text = paco.sched7;
            eighthORIG.Text = paco.sched8;
        }
        void PANDACANOrigin()
        {
            firstORIG.Text = pandacan.sched1;
            secondORIG.Text = pandacan.sched2;
            thirdORIG.Text = pandacan.sched3;
            fourthORIG.Text = pandacan.sched4;
            fifthORIG.Text = pandacan.sched5;
            sixthORIG.Text = pandacan.sched6;
            seventhORIG.Text = pandacan.sched7;
            eighthORIG.Text = pandacan.sched8;
        }
        void STAMESAOrigin()
        {
            firstORIG.Text = stamesa.sched1;
            secondORIG.Text = stamesa.sched2;
            thirdORIG.Text = stamesa.sched3;
            fourthORIG.Text = stamesa.sched4;
            fifthORIG.Text = stamesa.sched5;
            sixthORIG.Text = stamesa.sched6;
            seventhORIG.Text = stamesa.sched7;
            eighthORIG.Text = stamesa.sched8;
        }
        void ESPANAOrigin()
        {
            firstORIG.Text = espana.sched1;
            secondORIG.Text = espana.sched2;
            thirdORIG.Text = espana.sched3;
            fourthORIG.Text = espana.sched4;
            fifthORIG.Text = espana.sched5;
            sixthORIG.Text = espana.sched6;
            seventhORIG.Text = espana.sched7;
            eighthORIG.Text = espana.sched8;
        }
        void LAONLAANOrigin()
        {
            firstORIG.Text = laonlaan.sched1;
            secondORIG.Text = laonlaan.sched2;
            thirdORIG.Text = laonlaan.sched3;
            fourthORIG.Text = laonlaan.sched4;
            fifthORIG.Text = laonlaan.sched5;
            sixthORIG.Text = laonlaan.sched6;
            seventhORIG.Text = laonlaan.sched7;
            eighthORIG.Text = laonlaan.sched8;
        }
        void BLUMOrigin()
        {
            firstORIG.Text = blum.sched1;
            secondORIG.Text = blum.sched2;
            thirdORIG.Text = blum.sched3;
            fourthORIG.Text = blum.sched4;
            fifthORIG.Text = blum.sched5;
            sixthORIG.Text = blum.sched6;
            seventhORIG.Text = blum.sched7;
            eighthORIG.Text = blum.sched8;
        }
        void SOLISOrigin()
        {
            firstORIG.Text = solis.sched1;
            secondORIG.Text = solis.sched2;
            thirdORIG.Text = solis.sched3;
            fourthORIG.Text = solis.sched4;
            fifthORIG.Text = solis.sched5;
            sixthORIG.Text = solis.sched6;
            seventhORIG.Text = solis.sched7;
            eighthORIG.Text = solis.sched8;
        }
        void C31Origin()
        {
            firstORIG.Text = c3.sched1;
            secondORIG.Text = c3.sched2;
            thirdORIG.Text = c3.sched3;
            fourthORIG.Text = c3.sched4;
            fifthORIG.Text = c3.sched5;
            sixthORIG.Text = c3.sched6;
            seventhORIG.Text = c3.sched7;
            eighthORIG.Text = c3.sched8;
        }
        void ASISTIOOrigin()
        {
            firstORIG.Text = ass.sched1;
            secondORIG.Text = ass.sched2;
            thirdORIG.Text = ass.sched3;
            fourthORIG.Text = ass.sched4;
            fifthORIG.Text = ass.sched5;
            sixthORIG.Text = ass.sched6;
            seventhORIG.Text = ass.sched7;
            eighthORIG.Text = ass.sched8;
        }
        void SDAANOrigin()
        {
            firstORIG.Text = sdaan.sched1;
            secondORIG.Text = sdaan.sched2;
            thirdORIG.Text = sdaan.sched3;
            fourthORIG.Text = sdaan.sched4;
            fifthORIG.Text = sdaan.sched5;
            sixthORIG.Text = sdaan.sched6;
            seventhORIG.Text = sdaan.sched7;
            eighthORIG.Text = sdaan.sched8;
        }
        void GPOrigin()
        {
            firstORIG.Text = gp.sched1;
            secondORIG.Text = gp.sched2;
            thirdORIG.Text = gp.sched3;
            fourthORIG.Text = gp.sched4;
            fifthORIG.Text = gp.sched5;
            sixthORIG.Text = gp.sched6;
            seventhORIG.Text = gp.sched7;
            eighthORIG.Text = gp.sched8;
        }

        void BICDest()
        {
            firstDEST.Text = bic.sched1;
            secondDEST.Text = bic.sched2;
            thirdDEST.Text = bic.sched3;
            fourthDEST.Text = bic.sched4;
            fifthDEST.Text = bic.sched5;
            sixthDEST.Text = bic.sched6;
            seventhDEST.Text = bic.sched7;
            eighthDEST.Text = bic.sched8;
        }
        void NICDest()
        {
            firstDEST.Text = nic.sched1;
            secondDEST.Text = nic.sched2;
            thirdDEST.Text = nic.sched3;
            fourthDEST.Text = nic.sched4;
            fifthDEST.Text = nic.sched5;
            sixthDEST.Text = nic.sched6;
            seventhDEST.Text = nic.sched7;
            eighthDEST.Text = nic.sched8;
        }
        void FTIDest()
        {
            firstDEST.Text = fti.sched1;
            secondDEST.Text = fti.sched2;
            thirdDEST.Text = fti.sched3;
            fourthDEST.Text = fti.sched4;
            fifthDEST.Text = fti.sched5;
            sixthDEST.Text = fti.sched6;
            seventhDEST.Text = fti.sched7;
            eighthDEST.Text = fti.sched8;
        }
        void EDSADest()
        {
            firstDEST.Text = edsa.sched1;
            secondDEST.Text = edsa.sched2;
            thirdDEST.Text = edsa.sched3;
            fourthDEST.Text = edsa.sched4;
            fifthDEST.Text = edsa.sched5;
            sixthDEST.Text = edsa.sched6;
            seventhDEST.Text = edsa.sched7;
            eighthDEST.Text = edsa.sched8;
        }
        void PASAYDest()
        {
            firstDEST.Text = pasay.sched1;
            secondDEST.Text = pasay.sched2;
            thirdDEST.Text = pasay.sched3;
            fourthDEST.Text = pasay.sched4;
            fifthDEST.Text = pasay.sched5;
            sixthDEST.Text = pasay.sched6;
            seventhDEST.Text = pasay.sched7;
            eighthDEST.Text = pasay.sched8;
        }
        void DELAROSADest()
        {
            firstDEST.Text = delarosa.sched1;
            secondDEST.Text = delarosa.sched2;
            thirdDEST.Text = delarosa.sched3;
            fourthDEST.Text = delarosa.sched4;
            fifthDEST.Text = delarosa.sched5;
            sixthDEST.Text = delarosa.sched6;
            seventhDEST.Text = delarosa.sched7;
            eighthDEST.Text = delarosa.sched8;
        }
        void VITOCRUZDest()
        {
            firstDEST.Text = vitocruz.sched1;
            secondDEST.Text = vitocruz.sched2;
            thirdDEST.Text = vitocruz.sched3;
            fourthDEST.Text = vitocruz.sched4;
            fifthDEST.Text = vitocruz.sched5;
            sixthDEST.Text = vitocruz.sched6;
            seventhDEST.Text = vitocruz.sched7;
            eighthDEST.Text = vitocruz.sched8;
        }
        void SANANDRESDest()
        {
            firstDEST.Text = sanandres.sched1;
            secondDEST.Text = sanandres.sched2;
            thirdDEST.Text = sanandres.sched3;
            fourthDEST.Text = sanandres.sched4;
            fifthDEST.Text = sanandres.sched5;
            sixthDEST.Text = sanandres.sched6;
            seventhDEST.Text = sanandres.sched7;
            eighthDEST.Text = sanandres.sched8;
        }
        void PACODest()
        {
            firstDEST.Text = paco.sched1;
            secondDEST.Text = paco.sched2;
            thirdDEST.Text = paco.sched3;
            fourthDEST.Text = paco.sched4;
            fifthDEST.Text = paco.sched5;
            sixthDEST.Text = paco.sched6;
            seventhDEST.Text = paco.sched7;
            eighthDEST.Text = paco.sched8;
        }
        void PANDACANDest()
        {
            firstDEST.Text = pandacan.sched1;
            secondDEST.Text = pandacan.sched2;
            thirdDEST.Text = pandacan.sched3;
            fourthDEST.Text = pandacan.sched4;
            fifthDEST.Text = pandacan.sched5;
            sixthDEST.Text = pandacan.sched6;
            seventhDEST.Text = pandacan.sched7;
            eighthDEST.Text = pandacan.sched8;
        }
        void STAMESADest()
        {
            firstDEST.Text = stamesa.sched1;
            secondDEST.Text = stamesa.sched2;
            thirdDEST.Text = stamesa.sched3;
            fourthDEST.Text = stamesa.sched4;
            fifthDEST.Text = stamesa.sched5;
            sixthDEST.Text = stamesa.sched6;
            seventhDEST.Text = stamesa.sched7;
            eighthDEST.Text = stamesa.sched8;
        }
        void ESPANADest()
        {
            firstDEST.Text = espana.sched1;
            secondDEST.Text = espana.sched2;
            thirdDEST.Text = espana.sched3;
            fourthDEST.Text = espana.sched4;
            fifthDEST.Text = espana.sched5;
            sixthDEST.Text = espana.sched6;
            seventhDEST.Text = espana.sched7;
            eighthDEST.Text = espana.sched8;
        }
        void LAONLAANDest()
        {
            firstDEST.Text = laonlaan.sched1;
            secondDEST.Text = laonlaan.sched2;
            thirdDEST.Text = laonlaan.sched3;
            fourthDEST.Text = laonlaan.sched4;
            fifthDEST.Text = laonlaan.sched5;
            sixthDEST.Text = laonlaan.sched6;
            seventhDEST.Text = laonlaan.sched7;
            eighthDEST.Text = laonlaan.sched8;
        }
        void BLUMDest()
        {
            firstDEST.Text = blum.sched1;
            secondDEST.Text = blum.sched2;
            thirdDEST.Text = blum.sched3;
            fourthDEST.Text = blum.sched4;
            fifthDEST.Text = blum.sched5;
            sixthDEST.Text = blum.sched6;
            seventhDEST.Text = blum.sched7;
            eighthDEST.Text = blum.sched8;
        }
        void SOLISDest()
        {
            firstDEST.Text = solis.sched1;
            secondDEST.Text = solis.sched2;
            thirdDEST.Text = solis.sched3;
            fourthDEST.Text = solis.sched4;
            fifthDEST.Text = solis.sched5;
            sixthDEST.Text = solis.sched6;
            seventhDEST.Text = solis.sched7;
            eighthDEST.Text = solis.sched8;
        }
        void C31Dest()
        {
            firstDEST.Text = c3.sched1;
            secondDEST.Text = c3.sched2;
            thirdDEST.Text = c3.sched3;
            fourthDEST.Text = c3.sched4;
            fifthDEST.Text = c3.sched5;
            sixthDEST.Text = c3.sched6;
            seventhDEST.Text = c3.sched7;
            eighthDEST.Text = c3.sched8;
        }
        void ASISTIODest()
        {
            firstDEST.Text = ass.sched1;
            secondDEST.Text = ass.sched2;
            thirdDEST.Text = ass.sched3;
            fourthDEST.Text = ass.sched4;
            fifthDEST.Text = ass.sched5;
            sixthDEST.Text = ass.sched6;
            seventhDEST.Text = ass.sched7;
            eighthDEST.Text = ass.sched8;
        }
        void SDAANDest()
        {
            firstDEST.Text = sdaan.sched1;
            secondDEST.Text = sdaan.sched2;
            thirdDEST.Text = sdaan.sched3;
            fourthDEST.Text = sdaan.sched4;
            fifthDEST.Text = sdaan.sched5;
            sixthDEST.Text = sdaan.sched6;
            seventhDEST.Text = sdaan.sched7;
            eighthDEST.Text = sdaan.sched8;
        }
        void GPDest()
        {
            firstDEST.Text = gp.sched1;
            secondDEST.Text = gp.sched2;
            thirdDEST.Text = gp.sched3;
            fourthDEST.Text = gp.sched4;
            fifthDEST.Text = gp.sched5;
            sixthDEST.Text = gp.sched6;
            seventhDEST.Text = gp.sched7;
            eighthDEST.Text = gp.sched8;
        }
        void SView()
        {
            sview1.IsVisible = true;
        }
        void TrainLoc()
        {
            int bic1 = DateTime.Parse(bic.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int bic2 = DateTime.Parse(bic.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int bic3 = DateTime.Parse(bic.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int bic4 = DateTime.Parse(bic.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int bic5 = DateTime.Parse(bic.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int bic6 = DateTime.Parse(bic.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int bic7 = DateTime.Parse(bic.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int bic8 = DateTime.Parse(bic.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int fti1 = DateTime.Parse(fti.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int fti2 = DateTime.Parse(fti.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int fti3 = DateTime.Parse(fti.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int fti4 = DateTime.Parse(fti.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int fti5 = DateTime.Parse(fti.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int fti6 = DateTime.Parse(fti.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int fti7 = DateTime.Parse(fti.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int fti8 = DateTime.Parse(fti.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int nic1 = DateTime.Parse(nic.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int nic2 = DateTime.Parse(nic.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int nic3 = DateTime.Parse(nic.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int nic4 = DateTime.Parse(nic.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int nic5 = DateTime.Parse(nic.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int nic6 = DateTime.Parse(nic.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int nic7 = DateTime.Parse(nic.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int nic8 = DateTime.Parse(nic.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int edsa1 = DateTime.Parse(edsa.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int edsa2 = DateTime.Parse(edsa.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int edsa3 = DateTime.Parse(edsa.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int edsa4 = DateTime.Parse(edsa.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int edsa5 = DateTime.Parse(edsa.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int edsa6 = DateTime.Parse(edsa.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int edsa7 = DateTime.Parse(edsa.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int edsa8 = DateTime.Parse(edsa.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int pasay1 = DateTime.Parse(pasay.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pasay2 = DateTime.Parse(pasay.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pasay3 = DateTime.Parse(pasay.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pasay4 = DateTime.Parse(pasay.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pasay5 = DateTime.Parse(pasay.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pasay6 = DateTime.Parse(pasay.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pasay7 = DateTime.Parse(pasay.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pasay8 = DateTime.Parse(pasay.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int delarosa1 = DateTime.Parse(delarosa.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int delarosa2 = DateTime.Parse(delarosa.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int delarosa3 = DateTime.Parse(delarosa.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int delarosa4 = DateTime.Parse(delarosa.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int delarosa5 = DateTime.Parse(delarosa.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int delarosa6 = DateTime.Parse(delarosa.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int delarosa7 = DateTime.Parse(delarosa.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int delarosa8 = DateTime.Parse(delarosa.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int vitocruz1 = DateTime.Parse(vitocruz.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int vitocruz2 = DateTime.Parse(vitocruz.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int vitocruz3 = DateTime.Parse(vitocruz.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int vitocruz4 = DateTime.Parse(vitocruz.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int vitocruz5 = DateTime.Parse(vitocruz.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int vitocruz6 = DateTime.Parse(vitocruz.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int vitocruz7 = DateTime.Parse(vitocruz.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int vitocruz8 = DateTime.Parse(vitocruz.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int sanandres1 = DateTime.Parse(sanandres.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sanandres2 = DateTime.Parse(sanandres.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sanandres3 = DateTime.Parse(sanandres.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sanandres4 = DateTime.Parse(sanandres.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sanandres5 = DateTime.Parse(sanandres.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sanandres6 = DateTime.Parse(sanandres.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sanandres7 = DateTime.Parse(sanandres.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sanandres8 = DateTime.Parse(sanandres.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int paco1 = DateTime.Parse(paco.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int paco2 = DateTime.Parse(paco.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int paco3 = DateTime.Parse(paco.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int paco4 = DateTime.Parse(paco.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int paco5 = DateTime.Parse(paco.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int paco6 = DateTime.Parse(paco.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int paco7 = DateTime.Parse(paco.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int paco8 = DateTime.Parse(paco.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int pandacan1 = DateTime.Parse(pandacan.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pandacan2 = DateTime.Parse(pandacan.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pandacan3 = DateTime.Parse(pandacan.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pandacan4 = DateTime.Parse(pandacan.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pandacan5 = DateTime.Parse(pandacan.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pandacan6 = DateTime.Parse(pandacan.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pandacan7 = DateTime.Parse(pandacan.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int pandacan8 = DateTime.Parse(pandacan.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int stamesa1 = DateTime.Parse(stamesa.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int stamesa2 = DateTime.Parse(stamesa.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int stamesa3 = DateTime.Parse(stamesa.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int stamesa4 = DateTime.Parse(stamesa.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int stamesa5 = DateTime.Parse(stamesa.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int stamesa6 = DateTime.Parse(stamesa.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int stamesa7 = DateTime.Parse(stamesa.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int stamesa8 = DateTime.Parse(stamesa.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int espana1 = DateTime.Parse(espana.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int espana2 = DateTime.Parse(espana.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int espana3 = DateTime.Parse(espana.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int espana4 = DateTime.Parse(espana.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int espana5 = DateTime.Parse(espana.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int espana6 = DateTime.Parse(espana.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int espana7 = DateTime.Parse(espana.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int espana8 = DateTime.Parse(espana.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int laonlaan1 = DateTime.Parse(laonlaan.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int laonlaan2 = DateTime.Parse(laonlaan.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int laonlaan3 = DateTime.Parse(laonlaan.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int laonlaan4 = DateTime.Parse(laonlaan.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int laonlaan5 = DateTime.Parse(laonlaan.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int laonlaan6 = DateTime.Parse(laonlaan.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int laonlaan7 = DateTime.Parse(laonlaan.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int laonlaan8 = DateTime.Parse(laonlaan.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int blum1 = DateTime.Parse(blum.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int blum2 = DateTime.Parse(blum.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int blum3 = DateTime.Parse(blum.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int blum4 = DateTime.Parse(blum.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int blum5 = DateTime.Parse(blum.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int blum6 = DateTime.Parse(blum.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int blum7 = DateTime.Parse(blum.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int blum8 = DateTime.Parse(blum.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int solis1 = DateTime.Parse(solis.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int solis2 = DateTime.Parse(solis.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int solis3 = DateTime.Parse(solis.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int solis4 = DateTime.Parse(solis.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int solis5 = DateTime.Parse(solis.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int solis6 = DateTime.Parse(solis.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int solis7 = DateTime.Parse(solis.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int solis8 = DateTime.Parse(solis.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int c31 = DateTime.Parse(c3.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int c32 = DateTime.Parse(c3.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int c33 = DateTime.Parse(c3.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int c34 = DateTime.Parse(c3.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int c35 = DateTime.Parse(c3.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int c36 = DateTime.Parse(c3.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int c37 = DateTime.Parse(c3.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int c38 = DateTime.Parse(c3.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int ass1 = DateTime.Parse(ass.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int ass2 = DateTime.Parse(ass.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int ass3 = DateTime.Parse(ass.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int ass4 = DateTime.Parse(ass.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int ass5 = DateTime.Parse(ass.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int ass6 = DateTime.Parse(ass.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int ass7 = DateTime.Parse(ass.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int ass8 = DateTime.Parse(ass.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int sdaan1 = DateTime.Parse(sdaan.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sdaan2 = DateTime.Parse(sdaan.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sdaan3 = DateTime.Parse(sdaan.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sdaan4 = DateTime.Parse(sdaan.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sdaan5 = DateTime.Parse(sdaan.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sdaan6 = DateTime.Parse(sdaan.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sdaan7 = DateTime.Parse(sdaan.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int sdaan8 = DateTime.Parse(sdaan.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int gp1 = DateTime.Parse(gp.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int gp2 = DateTime.Parse(gp.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int gp3 = DateTime.Parse(gp.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int gp4 = DateTime.Parse(gp.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int gp5 = DateTime.Parse(gp.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int gp6 = DateTime.Parse(gp.sched6.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int gp7 = DateTime.Parse(gp.sched7.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int gp8 = DateTime.Parse(gp.sched8.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            if (bic1 == 0 || bic2 == 0 || bic3 == 0 || bic4 == 0 || bic5 == 0 || bic6 == 0 || bic6 == 0 || bic7 == 0 || bic8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: BICUTAN Station";
            }
            if (fti1 == 0 || fti2 == 0 || fti3 == 0 || fti4 == 0 || fti5 == 0 || fti6 == 0 || fti6 == 0 || fti7 == 0 || fti8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: FTI Station";
            }
            if (nic1 == 0 || nic2 == 0 || nic3 == 0 || nic4 == 0 || nic5 == 0 || nic6 == 0 || nic6 == 0 || nic7 == 0 || nic8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: NICHOLS Station";
            }
            if (edsa1 == 0 || edsa2 == 0 || edsa3 == 0 || edsa4 == 0 || edsa5 == 0 || edsa6 == 0 || edsa6 == 0 || edsa7 == 0 || edsa8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: EDSA Station";
            }
            if (pasay1 == 0 || pasay2 == 0 || pasay3 == 0 || pasay4 == 0 || pasay5 == 0 || pasay6 == 0 || pasay6 == 0 || pasay7 == 0 || pasay8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: PASAY ROAD Station";
            }
            if (delarosa1 == 0 || delarosa2 == 0 || delarosa3 == 0 || delarosa4 == 0 || delarosa5 == 0 || delarosa6 == 0 || delarosa6 == 0 || delarosa7 == 0 || delarosa8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: DELA ROSA Station";
            }
            if (vitocruz1 == 0 || vitocruz2 == 0 || vitocruz3 == 0 || vitocruz4 == 0 || vitocruz5 == 0 || vitocruz6 == 0 || vitocruz6 == 0 || vitocruz7 == 0 || vitocruz8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: VITO CRUZ Station";
            }
            if (sanandres1 == 0 || sanandres2 == 0 || sanandres3 == 0 || sanandres4 == 0 || sanandres5 == 0 || sanandres6 == 0 || sanandres6 == 0 || sanandres7 == 0 || sanandres8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: SAN ANDRES Station";
            }
            if (paco1 == 0 || paco2 == 0 || paco3 == 0 || paco4 == 0 || paco5 == 0 || paco6 == 0 || paco6 == 0 || paco7 == 0 || paco8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: PACO Station";
            }
            if (pandacan1 == 0 || pandacan2 == 0 || pandacan3 == 0 || pandacan4 == 0 || pandacan5 == 0 || pandacan6 == 0 || pandacan6 == 0 || pandacan7 == 0 || pandacan8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: PANDACAN Station";
            }
            if (stamesa1 == 0 || stamesa2 == 0 || stamesa3 == 0 || stamesa4 == 0 || stamesa5 == 0 || stamesa6 == 0 || stamesa6 == 0 || stamesa7 == 0 || stamesa8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: STA. MESA Station";
            }
            if (espana1 == 0 || espana2 == 0 || espana3 == 0 || espana4 == 0 || espana5 == 0 || espana6 == 0 || espana6 == 0 || espana7 == 0 || espana8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: ESPAÑA Station";
            }
            if (laonlaan1 == 0 || laonlaan2 == 0 || laonlaan3 == 0 || laonlaan4 == 0 || laonlaan5 == 0 || laonlaan6 == 0 || laonlaan6 == 0 || laonlaan7 == 0 || laonlaan8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: LAON LAAN Station";
            }
            if (blum1 == 0 || blum2 == 0 || blum3 == 0 || blum4 == 0 || blum5 == 0 || blum6 == 0 || blum6 == 0 || blum7 == 0 || blum8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: BLUMENTRITT Station";
            }
            if (solis1 == 0 || solis2 == 0 || solis3 == 0 || solis4 == 0 || solis5 == 0 || solis6 == 0 || solis6 == 0 || solis7 == 0 || solis8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: SOLIS Station";
            }
            if (c31 == 0 || c32 == 0 || c33 == 0 || c34 == 0 || c35 == 0 || c36 == 0 || c36 == 0 || c37 == 0 || c38 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: C3 / 5TH AVENUE Station";
            }
            if (ass1 == 0 || ass2 == 0 || ass3 == 0 || ass4 == 0 || ass5 == 0 || ass6 == 0 || ass6 == 0 || ass7 == 0 || ass8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: ASISTIO Station";
            }
            if (sdaan1 == 0 || sdaan2 == 0 || sdaan3 == 0 || sdaan4 == 0 || sdaan5 == 0 || sdaan6 == 0 || sdaan6 == 0 || sdaan7 == 0 || sdaan8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: SANGANDAAN Station";
            }
            if (gp1 == 0 || gp2 == 0 || gp3 == 0 || gp4 == 0 || gp5 == 0 || gp6 == 0 || gp6 == 0 || gp7 == 0 || gp8 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: GOV. PASCUAL Station";
            }
        }
        void TrainNumber()
        {
            firstTRAIN.Text = tno1.train1.ToString();
            secondTRAIN.Text = tno1.train2.ToString();
            thirdTRAIN.Text = tno1.train3.ToString();
            fourthTRAIN.Text = tno1.train4.ToString();
            fifthTRAIN.Text = tno1.train5.ToString();
            sixthTRAIN.Text = tno1.train6.ToString();
            seventhTRAIN.Text = tno1.train7.ToString();
            eighthTRAIN.Text = tno1.train8.ToString();


        }
    }
}
	
