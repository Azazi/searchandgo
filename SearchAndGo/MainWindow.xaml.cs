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
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Banner banner;
        public Window current;
        public static WrapPanel displayArea;
        public string searchString;
        public MainWindow()
        {
            InitializeComponent();
            displayArea = SearchResultsStackPanel;

            // Setup the banner
            setupBanner();

            // Setup categories
            addCategories();

            Help_Button.Click += new RoutedEventHandler(Help_Button_Click);
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);

            //searchBar.OnSearch += new RoutedEventHandler(m_txtTest_OnSearch);
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LWin || e.Key == Key.RWin) 
            {
                MessageBox.Show("Windows button should be disabled so users can't exit the program!!!");
            }
        }

        public static WrapPanel getMain()
        {
            return displayArea;
        }


        public void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            HelpPage helpPage = new HelpPage();
            helpPage.Show();
        }

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
            Thickness t = new Thickness(8, 8, 8, 0);
            banner.SetValue(MarginProperty, t);
            banner.start();
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

        private void addNike()
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                //ImageSource categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i1.jpg");
                //Image categoryImage = new Image();
                //categoryImage.Source = categorySource;
                //SearchResultItem newItem = new SearchResultItem("Nike Zoom Stefan", categoryImage);
                //SearchResultsStackPanel.Children.Add(newItem);

                //categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i2.jpg");
                //categoryImage = new Image();
                //categoryImage.Source = categorySource;
                //newItem = new SearchResultItem("Nike Dunk Mid", categoryImage);
                //SearchResultsStackPanel.Children.Add(newItem);

                //categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i3.jpg");
                //categoryImage = new Image();
                //categoryImage.Source = categorySource;
                //newItem = new SearchResultItem("Nike SB Lunar", categoryImage);
                //SearchResultsStackPanel.Children.Add(newItem);

                //categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i4.jpg");
                //categoryImage = new Image();
                //categoryImage.Source = categorySource;
                //newItem = new SearchResultItem("Nike SB Januski", categoryImage);
                //SearchResultsStackPanel.Children.Add(newItem);

                //categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i5.jpg");
                //categoryImage = new Image();
                //categoryImage.Source = categorySource;
                //newItem = new SearchResultItem("Nike Project BA", categoryImage);
                //SearchResultsStackPanel.Children.Add(newItem);
            }));
        }

        private void MainSearchBar_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
                MainSearchBar.Text = "";
        }

        private void MainSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            searchString = MainSearchBar.Text;
            if (e.Key == Key.Enter)
            {
                DisplayToMainView.displayInContentArea(displayArea, FakeDB.fakeDataBaseQuery(MainSearchBar.Text));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayToMainView.displayInContentArea(displayArea, FakeDB.fakeDataBaseQuery(searchString));
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