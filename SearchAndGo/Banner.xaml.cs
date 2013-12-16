using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Transitionals;
using Transitionals.Controls;
using Transitionals.Transitions;
using System.Timers;

namespace SearchAndGo
{
    /// <summary>
    /// Interaction logic for Banner.xaml
    /// </summary>
    public partial class Banner : UserControl
    {
        public TransitionElement transitionElement;
        public List<Image> ads;

        List<RadioButton> radioButtons;
        Timer adTimer;
        int currentAd = 0;

        public Banner()
        {
            InitializeComponent();

            // Initialization
            transitionElement = new TransitionElement();
            ads = new List<Image>();
            radioButtons = new List<RadioButton>();

            // Setup timer
            setupTimer();

            // Setup transition
            //TranslateTransition translateTransition = new TranslateTransition();
            //translateTransition.Duration = new Duration(new TimeSpan(0, 0, 1));

            RotateTransition rotateTransition = new RotateTransition();
            rotateTransition.Angle = 90;
            transitionElement.Transition = rotateTransition;
            adsStackPanel.Children.Add(transitionElement);

            // Setup event handlers for buttons
            leftButton.Click += new RoutedEventHandler(leftButton_Click);
            rightButton.Click += new RoutedEventHandler(rightButton_Click);
            adsStackPanel.MouseLeftButtonUp += new MouseButtonEventHandler(adsStackPanel_MouseLeftButtonUp);
        }

        public void newAdd(Image image)
        {
            ads.Add(image);
            RadioButton newRadioButton = new RadioButton();
            radioButtons.Add(newRadioButton);
            radioButtonsStackPanel.Children.Add(newRadioButton);
        }

        public void start()
        {
            if (ads.Count > 0)
            {
                this.Dispatcher.Invoke(new Action(delegate()
                {
                    transitionElement.Content = ads[currentAd];
                    radioButtons[currentAd].IsChecked = true;
                }));
            }
        }

        private void adsStackPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string message = "This should take you to special offer number " + currentAd.ToString() + "\n Under Construction";
            MessageBox.Show(message, "Offer Clicked");
        }

        void rightButton_Click(object sender, RoutedEventArgs e)
        {
            adTimer.Stop();
            adTimer_Elapsed(sender, null);            
            adTimer.Start();
        }

        void leftButton_Click(object sender, RoutedEventArgs e)
        {
            adTimer.Stop();

            // Set transition direction 
            // TODO: the angle doesn't accept negative values! 
            // We might want to change the angle to something that makes sense
            RotateTransition rotateTransition = new RotateTransition();
            rotateTransition.Angle = 0;
            transitionElement.Transition = rotateTransition;

            currentAd = (currentAd - 2 + ads.Count) % ads.Count;
            adTimer_Elapsed(sender, null);

            // Re-set transition direction
            rotateTransition.Angle = 90;
            transitionElement.Transition = rotateTransition;
            
            adTimer.Start();
        }

        private void setupTimer()
        {
            adTimer = new Timer();
            adTimer.Elapsed += new ElapsedEventHandler(adTimer_Elapsed);

            adTimer.Interval = 6000;
            adTimer.Enabled = true;
        }

        void adTimer_Elapsed(object sender, ElapsedEventArgs e)
        {            
            int numberOfAds = ads.Count;
            currentAd = (currentAd + 1) % numberOfAds;
            if (numberOfAds > 0)
            {
                this.Dispatcher.Invoke(new Action(delegate()
                {
                    transitionElement.Content = ads[currentAd];
                    radioButtons[currentAd].IsChecked = true;
                }));
            }
        }
    }
}
