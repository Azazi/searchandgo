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
using System.IO;
#endregion

namespace SearchAndGo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Banner banner;
        public Window current;
        public static WrapPanel displayArea;
        public string searchString;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            displayArea = SearchResultsStackPanel;

            // Setup the banner
            setupBanner();

            // Setup categories
            addCategories();

            // Setup event handlers for the window
            setupHandlers();
        }

        public static WrapPanel getMain()
        {
            return displayArea;
        }

        private void addCategories()
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                //displayInContentArea(new CategoryBrowser(fakeDataBaseQuery("hockey").First()));
                //displayInContentArea(new CategoryBrowser(fakeDataBaseQuery("apparel").First()));
                //displayInContentArea(new CategoryBrowser(fakeDataBaseQuery("backpack").First()));
                //displayInContentArea(new CategoryBrowser(fakeDataBaseQuery("jacket").First()));
                //displayInContentArea(new CategoryBrowser(fakeDataBaseQuery("skates").First()));
                //displayInContentArea(new CategoryBrowser(fakeDataBaseQuery("fanshop").First()));
                //displayInContentArea(new CategoryBrowser(fakeDataBaseQuery("basketball").First()));
                //displayInContentArea(new CategoryBrowser(fakeDataBaseQuery("sneakers").First()));

                List<string> allCat = FakeDB.getAllCategories();
                List<CategoryBrowser> listOfallCategories = new List<CategoryBrowser>();
                foreach (string category in allCat)
                {
                    SearchResultItem anItem = FakeDB.fakeDataBaseQuery(category).First();
                    CategoryBrowser aCategory = new CategoryBrowser(anItem);
                    listOfallCategories.Add(aCategory);
                }
                DisplayToMainView.displayInContentArea(displayArea, listOfallCategories);
            }));
        }

        //private void MainSearchBar_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        //{
        //    searchBar.Text = "";
        //}

        private void MainSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            searchString = searchBar.Text;
            if (e.Key == Key.Enter)
            {
                DisplayToMainView.displayInContentArea(displayArea, FakeDB.fakeDataBaseQuery(searchBar.Text));
            }
        }

        #region Event Handlers
        void setupHandlers()
        {
            searchBar.GotFocus += new RoutedEventHandler(searchBar_GotFocus);
            searchBar.LostFocus += new RoutedEventHandler(searchBar_LostFocus);
            Search_Button.Click += new RoutedEventHandler(Search_Button_Click);

            Home_Button.Click += new RoutedEventHandler(Home_Button_Click);
            Help_Button.Click += new RoutedEventHandler(Help_Button_Click);
            
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);
        }

        void searchBar_LostFocus(object sender, RoutedEventArgs e)
        {
            searchBar.Text = "Search";
        }

        void searchBar_GotFocus(object sender, RoutedEventArgs e)
        {
            searchBar.Text = "";
        }

        void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayToMainView.displayInContentArea(displayArea, FakeDB.fakeDataBaseQuery(searchString));
        }

        void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            addCategories();
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LWin || e.Key == Key.RWin) 
            {
                MessageBox.Show("Windows button should be disabled so users can't exit the program!!!");
            }
        }

        public void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpPage = new HelpWindow();
            helpPage.Show();
        }
        #endregion

        /// <summary>
        /// Setup the banner
        /// </summary>
        private void setupBanner()
        {
            banner = new Banner();
            ImageSource imageSrc = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\i1.jpg");
            Image i1 = new Image();
            i1.Source = imageSrc;

            imageSrc = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\i2.jpg");
            Image i2 = new Image();
            i2.Source = imageSrc;

            imageSrc = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\i3.jpg");
            Image i3 = new Image();
            i3.Source = imageSrc;

            banner.newAdd(i1);
            banner.newAdd(i2);
            banner.newAdd(i3);

            this.Dispatcher.Invoke((Action)(() =>
            {
                grid.Children.Add(banner);
            }));

            banner.SetValue(Grid.RowProperty, 2);
            Thickness bannerThickness = new Thickness(8, 8, 8, 0);
            banner.SetValue(MarginProperty, bannerThickness);
            banner.start();
        }

        #region Automatically Generated Code
        /// <summary>
        /// Occurs when the window is about to close. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
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