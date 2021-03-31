using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace PNRSched
{

    public class OnboardingViewModel : MvvmHelpers.BaseViewModel
    {
        private ObservableCollection<OnboardingModel> items;
        private int position;
        private string skipButtonText;

        public OnboardingViewModel()
        {
            SetSkipButtonText("SKIP");
            InitializeOnBoarding();
            InitializeSkipCommand();
        }

        private void SetSkipButtonText(string skipButtonText)
                => SkipButtonText = skipButtonText;

        private void InitializeOnBoarding()
        {
            Items = new ObservableCollection<OnboardingModel>
            {
                new OnboardingModel
                {
                    Title = "Welcome to \n PNR Schedule",
                    Content = "PNR Schedule helps you view the schedule of trains for specific routes so you won't be late to your trips anymore",
                    ImageUrl = "pnr_tren.png"
                },
                new OnboardingModel
                {
                    Title = "Choose routes",
                    Content = "Specify your ORIGIN station and DESTINATION station",
                    ImageUrl = "entries.jpg" //sc to be added later // sc ng entries
                },
                new OnboardingModel
                {
                    Title = "Specify departure time",
                    Content = "Specify your departure time to show the nearest available train in your ORIGIN station",
                    ImageUrl = "time.jpg" //sc ng time picker
                },
                new OnboardingModel
                {
                    Title = "View your itinerary",
                    Content = "After supplying required informations, useful information will appear like your itinerary, duration of trip, and much more",
                    ImageUrl = "itinerary.jpg" //sc ng bottomsheet
                },
                new OnboardingModel
                {
                    Title = "Have a safe ride at Philippine National Railways!",
                    Content = "",
                    ImageUrl = "onboarding.png"
                }
            };
        }

        private void InitializeSkipCommand()
        {
            SkipCommand = new Command(() =>
            {
                if (LastPositionReached())
                {
                    ExitOnBoarding();
                }
                else
                {
                    MoveToNextPosition();
                }
            });
        }

        private static void ExitOnBoarding()
        {
            Application.Current.MainPage.Navigation.PopModalAsync(true);

        }


        private void MoveToNextPosition()
        {
            Position += 1;
        }

        private bool LastPositionReached()
            => Position == Items.Count - 1;

        public ObservableCollection<OnboardingModel> Items
        {
            get => items;
            set => SetProperty(ref items, value);
        }

        public string SkipButtonText
        {
            get => skipButtonText;
            set => SetProperty(ref skipButtonText, value);
        }

        public int Position
        {
            get => position;
            set
            {
                if (SetProperty(ref position, value))
                {
                    UpdateSkipButtonText();
                }
            }
        }

        private void UpdateSkipButtonText()
        {
            if (LastPositionReached())
            {
                SetSkipButtonText("GOT IT");
            }
            else
            {
                SetSkipButtonText("SKIP");
            }
        }

        public ICommand SkipCommand { get; private set; }
    }
}
