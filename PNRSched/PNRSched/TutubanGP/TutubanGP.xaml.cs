using Microsoft.AppCenter.Analytics;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;
using XLabs.Platform.Device;

namespace PNRSched
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TutubanGP : ContentPage
    {
        readonly Tutuban tb = new Tutuban();
        readonly Solis sls = new Solis();
        readonly C3 c3 = new C3();
        readonly Asistio ass = new Asistio();
        readonly Sangandaan sd = new Sangandaan();
        readonly GP gp = new GP();
        public TutubanGP()
        {
            InitializeComponent();
            bottomSheet.IsVisible = false;
            timePICKER.Time = DateTime.Now.TimeOfDay;
            timePICKER.Format = "hh:mm tt";

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
            Analytics.TrackEvent("GradientButton_Clicked");
        }
        private void GradientButton_Clicked(object sender, EventArgs e)
        {
            var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getProportionCoordinate(.80))); //bago, pang animate pag button clock
            bottomSheet.TranslateTo(bottomSheet.X, finalTranslation, 500, Easing.CubicInOut);
            try
            {          
                bottomSheet.IsVisible = true;
                labelORIG.Text = pckrORIGIN.SelectedItem.ToString();
                labelDEST.Text = pckrDEST.SelectedItem.ToString();

                var time1 = DateTime.Parse(firstDEST.Text).Subtract(DateTime.Parse(firstORIG.Text)).Minutes.ToString();
                labelDURATION.Text = time1.ToString() + " mins";

                if (pckrORIGIN.SelectedIndex == 0)
                {


                    int res1 = DateTime.Parse(tb.sched1).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res2 = DateTime.Parse(tb.sched2).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res3 = DateTime.Parse(tb.sched3).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res4 = DateTime.Parse(tb.sched4).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res5 = DateTime.Parse(tb.sched5).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", tb.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", tb.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", tb.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", tb.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", tb.sched5.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 1)
                {


                    int res1 = DateTime.Parse(sls.sched1).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res2 = DateTime.Parse(sls.sched2).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res3 = DateTime.Parse(sls.sched3).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res4 = DateTime.Parse(sls.sched4).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res5 = DateTime.Parse(sls.sched5).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sls.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sls.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sls.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sls.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sls.sched5.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 2)
                {

                    int res1 = DateTime.Parse(c3.sched1).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res2 = DateTime.Parse(c3.sched2).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res3 = DateTime.Parse(c3.sched3).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res4 = DateTime.Parse(c3.sched4).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res5 = DateTime.Parse(c3.sched5).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
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
                }
                if (pckrORIGIN.SelectedIndex == 3)
                {


                    int res1 = DateTime.Parse(ass.sched1).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res2 = DateTime.Parse(ass.sched2).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res3 = DateTime.Parse(ass.sched3).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res4 = DateTime.Parse(ass.sched4).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res5 = DateTime.Parse(ass.sched5).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
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
                }
                if (pckrORIGIN.SelectedIndex == 4)
                {


                    int res1 = DateTime.Parse(sd.sched1).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res2 = DateTime.Parse(sd.sched2).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res3 = DateTime.Parse(sd.sched3).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res4 = DateTime.Parse(sd.sched4).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res5 = DateTime.Parse(sd.sched5).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    if (res1 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sd.sched1.ToString());

                    }
                    else if (res2 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sd.sched2.ToString());

                    }
                    else if (res3 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sd.sched3.ToString());

                    }
                    else if (res4 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sd.sched4.ToString());

                    }
                    else if (res5 > 0)
                    {
                        labelCLOSESTTIME.Text = string.Format("ETA of train on origin station: {0}", sd.sched5.ToString());

                    }
                }
                if (pckrORIGIN.SelectedIndex == 5)
                {
                    int res1 = DateTime.Parse(gp.sched1).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res2 = DateTime.Parse(gp.sched2).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res3 = DateTime.Parse(gp.sched3).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res4 = DateTime.Parse(gp.sched4).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
                    int res5 = DateTime.Parse(gp.sched5).CompareTo(DateTime.Parse(timePICKER.Time.ToString()));
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
                }
                TrainLoc();
            }
            catch (Exception)
            {
                pckrORIGIN.SelectedIndex = -1;
                pckrDEST.SelectedIndex = -1;
                bottomSheet.IsVisible = false;
                entryTIME1.IsEnabled = true;
                entryTIME1.IsVisible = true;
                timePICKER.IsVisible = false;
                timePICKER.IsEnabled = false;
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
                    TutubanOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 1)
                {
                    SView();
                    SolisOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 2)
                {
                    SView();
                    C3Origin();
                }
                if (pckrORIGIN.SelectedIndex == 3)
                {
                    SView();
                    AsistioOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 4)
                {
                    SView();
                    SDaanOrigin();
                }
                if (pckrORIGIN.SelectedIndex == 5 && pckrDEST.SelectedIndex == 5)
                {
                    SView();
                    GPSameOrigDest();
                }

                if (pckrDEST.SelectedIndex == 0)
                {
                    SView();
                    TutubanDest();
                }
                if (pckrDEST.SelectedIndex == 1)
                {
                    SView();
                    SolisDest();
                }
                if (pckrDEST.SelectedIndex == 2)
                {
                    SView();
                    C3Dest();
                }
                if (pckrDEST.SelectedIndex == 3)
                {
                    SView();
                    AsistioDest();
                }
                if (pckrDEST.SelectedIndex == 4)
                {
                    SView();
                    SDaanDest();
                }
                if (pckrDEST.SelectedIndex == 5)
                {
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
                DisplayAlert("Notice", "Please fill up the FROM, TO, and WHEN fields in their respective order before pressing the view schedule button", "Okay");
            }
        }

        private void EntryTIME1_Focused(object sender, FocusEventArgs e)
        {
            timePICKER.Focus();
            entryTIME1.IsEnabled = false;
            entryTIME1.IsVisible = false;
            timePICKER.IsVisible = true;
            timePICKER.IsEnabled = true;
            timePICKER.Format = "hh:mm tt";
        }
        public double getProportionCoordinate(double proportion)
        {
            return proportion * Height;
        } //bago
        void TutubanOrigin()
        {
            TrainNumber tno = new TrainNumber(); Tutuban tb = new Tutuban();
            firstTRAIN.Text = tno.train1;
            firstORIG.Text = tb.sched1;

            secondTRAIN.Text = tno.train2;
            secondORIG.Text = tb.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdORIG.Text = tb.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthORIG.Text = tb.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthORIG.Text = tb.sched5;



        }
        void SolisOrigin()
        {
            TrainNumber tno = new TrainNumber(); Solis sls = new Solis();
            firstTRAIN.Text = tno.train1;
            firstORIG.Text = sls.sched1;

            secondTRAIN.Text = tno.train2;
            secondORIG.Text = sls.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdORIG.Text = sls.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthORIG.Text = sls.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthORIG.Text = sls.sched5;
        }
        void C3Origin()
        {
            TrainNumber tno = new TrainNumber(); C3 c3 = new C3();
            firstTRAIN.Text = tno.train1;
            firstORIG.Text = c3.sched1;

            secondTRAIN.Text = tno.train2;
            secondORIG.Text = c3.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdORIG.Text = c3.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthORIG.Text = c3.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthORIG.Text = c3.sched5;
        }
        void AsistioOrigin()
        {
            TrainNumber tno = new TrainNumber(); Asistio ass = new Asistio();
            firstTRAIN.Text = tno.train1;
            firstORIG.Text = ass.sched1;

            secondTRAIN.Text = tno.train2;
            secondORIG.Text = ass.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdORIG.Text = ass.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthORIG.Text = ass.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthORIG.Text = ass.sched5;
        }
        void SDaanOrigin()
        {
            TrainNumber tno = new TrainNumber(); Sangandaan sdaan = new Sangandaan();
            firstTRAIN.Text = tno.train1;
            firstORIG.Text = sdaan.sched1;

            secondTRAIN.Text = tno.train2;
            secondORIG.Text = sdaan.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdORIG.Text = sdaan.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthORIG.Text = sdaan.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthORIG.Text = sdaan.sched5;
        }
        void TutubanDest()
        {
            TrainNumber tno = new TrainNumber(); Tutuban tb = new Tutuban();
            firstTRAIN.Text = tno.train1;
            firstDEST.Text = tb.sched1;

            secondTRAIN.Text = tno.train2;
            secondDEST.Text = tb.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdDEST.Text = tb.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthDEST.Text = tb.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthDEST.Text = tb.sched5;
        }
        void SolisDest()
        {
            TrainNumber tno = new TrainNumber(); Solis tb = new Solis();
            firstTRAIN.Text = tno.train1;
            firstDEST.Text = sls.sched1;

            secondTRAIN.Text = tno.train2;
            secondDEST.Text = tb.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdDEST.Text = tb.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthDEST.Text = tb.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthDEST.Text = tb.sched5;
        }
        void C3Dest()
        {
            TrainNumber tno = new TrainNumber(); C3 c3 = new C3();
            firstTRAIN.Text = tno.train1;
            firstDEST.Text = c3.sched1;

            secondTRAIN.Text = tno.train2;
            secondDEST.Text = c3.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdDEST.Text = c3.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthDEST.Text = c3.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthDEST.Text = c3.sched5;
        }
        void AsistioDest()
        {
            TrainNumber tno = new TrainNumber(); Asistio ass = new Asistio();
            firstTRAIN.Text = tno.train1;
            firstDEST.Text = ass.sched1;

            secondTRAIN.Text = tno.train2;
            secondDEST.Text = ass.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdDEST.Text = ass.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthDEST.Text = ass.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthDEST.Text = ass.sched5;
        }
        void SDaanDest()
        {
            TrainNumber tno = new TrainNumber(); Sangandaan tb = new Sangandaan();
            firstTRAIN.Text = tno.train1;
            firstDEST.Text = tb.sched1;

            secondTRAIN.Text = tno.train2;
            secondDEST.Text = tb.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdDEST.Text = tb.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthDEST.Text = tb.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthDEST.Text = tb.sched5;
        }
        void GPDest()
        {
            TrainNumber tno = new TrainNumber(); GP gp = new GP();
            firstTRAIN.Text = tno.train1;
            firstDEST.Text = gp.sched1;

            secondTRAIN.Text = tno.train2;
            secondDEST.Text = gp.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdDEST.Text = gp.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthDEST.Text = gp.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthDEST.Text = gp.sched5;
        }
        void GPSameOrigDest()
        {
            TrainNumber tno = new TrainNumber(); GP gp = new GP();
            firstTRAIN.Text = tno.train1;
            firstDEST.Text = gp.sched1;
            firstORIG.Text = gp.sched1;

            secondTRAIN.Text = tno.train2;
            secondDEST.Text = gp.sched2;
            secondORIG.Text = gp.sched2;

            thirdTRAIN.Text = tno.train3;
            thirdDEST.Text = gp.sched3;
            thirdORIG.Text = gp.sched3;

            fourthTRAIN.Text = tno.train4;
            fourthDEST.Text = gp.sched4;
            fourthORIG.Text = gp.sched4;

            fifthTRAIN.Text = tno.train5;
            fifthDEST.Text = gp.sched5;
            fifthORIG.Text = gp.sched5;
        }
        void SView()
        {
            sview1.IsVisible = true;
        }
        void TrainLoc()
        {

            int res1 = DateTime.Parse(tb.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res2 = DateTime.Parse(tb.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res3 = DateTime.Parse(tb.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res4 = DateTime.Parse(tb.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res5 = DateTime.Parse(tb.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int res6 = DateTime.Parse(sls.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res7 = DateTime.Parse(sls.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res8 = DateTime.Parse(sls.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res9 = DateTime.Parse(sls.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res10 = DateTime.Parse(sls.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int res11 = DateTime.Parse(c3.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res12 = DateTime.Parse(c3.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res13 = DateTime.Parse(c3.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res14 = DateTime.Parse(c3.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res15 = DateTime.Parse(c3.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int res16 = DateTime.Parse(ass.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res17 = DateTime.Parse(ass.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res18 = DateTime.Parse(ass.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res19 = DateTime.Parse(ass.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res20 = DateTime.Parse(ass.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int res21 = DateTime.Parse(sd.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res22 = DateTime.Parse(sd.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res23 = DateTime.Parse(sd.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res24 = DateTime.Parse(sd.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res25 = DateTime.Parse(sd.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            int res26 = DateTime.Parse(gp.sched1.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res27 = DateTime.Parse(gp.sched2.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res28 = DateTime.Parse(gp.sched3.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res29 = DateTime.Parse(gp.sched4.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));
            int res30 = DateTime.Parse(gp.sched5.ToString()).CompareTo(DateTime.Parse(DateTime.Now.ToShortTimeString()));

            if (res1 == 0 || res2 == 0 || res3 == 0 || res4 == 0 || res5 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: TUTUBAN Station";
            }
            if (res6 == 0 || res7 == 0 || res8 == 0 || res9 == 0 || res10 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: SOLIS Station";
            }
            if (res11 == 0 || res12 == 0 || res13 == 0 || res14 == 0 || res15 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: C3/5TH AVENUE Station";
            }
            if (res16 == 0 || res17 == 0 || res18 == 0 || res19 == 0 || res20 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: ASISTIO Station";
            }

            if (res21 == 0 || res22 == 0 || res23 == 0 || res24 == 0 || res25 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: SANGANDAAN Station";
            }
            if (res26 == 0 || res27 == 0 || res28 == 0 || res29 == 0 || res30 == 0)
            {
                labelLOCTRAIN.Text = "Approximate location of train: GOV.PASCUAL Station";
            }
        }
    }
}