using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PNRSched
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Try : ContentPage
    {
        public Try()
        {
            InitializeComponent();
            pckrORIG.Items.Add("TUTUBAN");
            pckrDEST.Items.Add("SOLIS");
        }
        public double getProportionCoordinate(double proportion)
        {
            return proportion * Height;
        } //bago
        public double getClosestLockState(double TranslationY)
        {
            //Play with these values to adjust the locking motions - this will change depending on the amount of content ona  apge
            var lockStates = new double[] { 0, .15, .3, .65, .75 };

            ////get the current proportion of the sheet in relation to the screen
            var distance = Math.Abs(TranslationY);
            var currentProportion = distance / Height;

            //calculate which lockstate it's the closest to
            var smallestDistance = 10000.0;
            var closestIndex = 0;
            for (var i = 0; i < lockStates.Length; i++)
            {
                var state = lockStates[i];
                var absoluteDistance = Math.Abs(state - currentProportion);
                if (absoluteDistance < smallestDistance)
                {
                    smallestDistance = absoluteDistance;
                    closestIndex = i;
                }
            }

            var selectedLockState = lockStates[closestIndex];
            var TranslateToLockState = getProportionCoordinate(selectedLockState);

            return TranslateToLockState;
        } //bago
        private void GradientButton_Clicked(object sender, EventArgs e)
        {
            btmSHEET.IsVisible = true;
            var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getProportionCoordinate(.80))); //bago, pang animate pag button clock
            btmSHEET.TranslateTo(btmSHEET.X, finalTranslation, 500, Easing.CubicInOut);
        }

        private void EntryTIME1_Focused(object sender, FocusEventArgs e)
        {
            timePCKR.Focus();
            entryTIME1.IsEnabled = false;
            entryTIME1.IsVisible = false;
            timePCKR.IsVisible = true;
            timePCKR.IsEnabled = true;
            timePCKR.Format = "hh:mm tt";
        }
        public double y;
        private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    //btmSHEET.TranslationY = Math.Max(80, Math.Min(sview1.HeightRequest, btmSHEET.TranslationY + e.TotalY));

                    break;
            }
        }
    }
}