#region Usings

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
using System.Drawing;

#endregion

namespace SearchAndGo
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public WelcomeWindow()
        {
            InitializeComponent();

            // Sets up button behaviour
            setupButtonAppearance();
            
            // Add handlers for window availability events
            AddWindowAvailabilityHandlers();
        }

        #region Button Setup

        /// <summary>
        /// Setup button behaviour
        /// </summary>
        void setupButtonAppearance()
        {
            touchToStartButton.MouseEnter += new MouseEventHandler(touchToStartButton_MouseEnter);
            touchToStartButton.TouchEnter += new EventHandler<TouchEventArgs>(touchToStartButton_TouchEnter);

            touchToStartButton.MouseLeave += new MouseEventHandler(touchToStartButton_MouseLeave);
            touchToStartButton.TouchLeave += new EventHandler<TouchEventArgs>(touchToStartButton_TouchLeave);

            touchezPourDemarrerButton.MouseEnter += new MouseEventHandler(touchToStartButton_MouseEnter);
            touchezPourDemarrerButton.TouchEnter += new EventHandler<TouchEventArgs>(touchToStartButton_TouchEnter);

            touchezPourDemarrerButton.MouseLeave += new MouseEventHandler(touchToStartButton_MouseLeave);
            touchezPourDemarrerButton.TouchLeave += new EventHandler<TouchEventArgs>(touchToStartButton_TouchLeave);

            touchToStartButton.Click += new RoutedEventHandler(touchToStartButton_Click);
            touchToStartButton.TouchDown += new EventHandler<TouchEventArgs>(touchToStartButton_Click);

            touchezPourDemarrerButton.Click += new RoutedEventHandler(touchToStartButton_Click);
            touchezPourDemarrerButton.TouchDown += new EventHandler<TouchEventArgs>(touchToStartButton_Click);
        }

        /// <summary>
        /// Setup the main window upon click/touch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void touchToStartButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            App.Current.MainWindow = mainWindow;
            mainWindow.Show();
            this.Hide();
        }

        /// <summary>
        /// Setup button as touch leaves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void touchToStartButton_TouchLeave(object sender, TouchEventArgs e)
        {
            touchToStartButton_MouseLeave(sender, null);
        }

        /// <summary>
        /// Setup button as touch enters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void touchToStartButton_TouchEnter(object sender, TouchEventArgs e)
        {
            touchToStartButton_MouseEnter(sender, null);
        }

        /// <summary>
        /// Setup buttons as mouse leaves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void touchToStartButton_MouseLeave(object sender, MouseEventArgs e)
        {
            string name = "";
            if ((sender as Button).Name.Contains("Start")){ name = "EN"; }
            else { name = "FR"; }

            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\"+name+".png");
            (sender as Button).Background = imageBrush;
            //touchToStartButton.Background = imageBrush;
        }

        /// <summary>
        /// Setup buttons as mouse enters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void touchToStartButton_MouseEnter(object sender, MouseEventArgs e)
        {
            string name = "";
            if ((sender as Button).Name.Contains("Start")) { name = "EN"; }
            else { name = "FR"; }

            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\"+name+"Pressed.png");
            (sender as Button).Background = imageBrush;
            //touchToStartButton.Background = imageBrush;
        }

        #endregion

        #region Auto-Generated Code
        /// <summary>
        /// Occurs when the window is about to close. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // Remove handlers for window availability events
            RemoveWindowAvailabilityHandlers();
        }

        /// <summary>
        /// Adds handlers for window availability events.
        /// </summary>
        private void AddWindowAvailabilityHandlers()
        {
        }

        /// <summary>
        /// Removes handlers for window availability events.
        /// </summary>
        private void RemoveWindowAvailabilityHandlers()
        {
        }

        /// <summary>
        /// This is called when the user can interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowInteractive(object sender, EventArgs e)
        {
            //TODO: enable audio, animations here
        }

        /// <summary>
        /// This is called when the user can see but not interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowNoninteractive(object sender, EventArgs e)
        {
            //TODO: Disable audio here if it is enabled

            //TODO: optionally enable animations here
        }

        /// <summary>
        /// This is called when the application's window is not visible or interactive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowUnavailable(object sender, EventArgs e)
        {
            //TODO: disable audio, animations here
        }
        #endregion
    }
}