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
using Microsoft.Surface;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using Microsoft.Surface.Presentation.Input;
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
        public MainWindow()
        {
            InitializeComponent();

            // Setup the banner
            setupBanner();

            // Setup categories
            addCategories();

            Help_Button.Click += new RoutedEventHandler(Help_Button_Click);

            // Add handlers for window availability events
            AddWindowAvailabilityHandlers();
        }

        void Help_Button_Click(object sender, RoutedEventArgs e)
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

        void addCategories()
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                // Document
                ImageSource categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\hockey.jpg");
                Image categoryImage = new Image();
                categoryImage.Source = categorySource;
                SearchResultItem newItem = new SearchResultItem("Hockey", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\apparel.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Apparel", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\backpack.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Outdoors", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\jacket.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Jackets", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\skates.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Skating", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\sneakers.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Footwear", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\fanshop.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Fan Shop", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\basketball.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Basketball", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);
            }));
        }

        void addNike()
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                ImageSource categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i1.jpg");
                Image categoryImage = new Image();
                categoryImage.Source = categorySource;
                SearchResultItem newItem = new SearchResultItem("Nike Zoom Stefan", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i2.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Nike Dunk Mid", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i3.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Nike SB Lunar", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i4.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Nike SB Januski", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i5.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem("Nike Project BA", categoryImage);
                SearchResultsStackPanel.Children.Add(newItem);
            }));
        }

        #region searchBar
        void m_txtTest_OnSearch(object sender, RoutedEventArgs e)
        {
            SearchEventArgs searchArgs = e as SearchEventArgs;
            
            // Display search data
            string sections = "\r\nSections(s): ";
            foreach (string section in searchArgs.Sections)
                sections += (section + "; ");
            //m_txtSearchContent.Text = "Keyword: " + searchArgs.Keyword + sections;

            List<Image> result = fakeDataBaseQuery(searchArgs.Keyword);
            List<SearchAndGo.SearchResultItem> displayOfResults = new List<SearchAndGo.SearchResultItem>();

            foreach (Image currResult in result)
            {
                displayOfResults.Add(new SearchResultItem(currResult.Source.ToString().Split('/').Last(), currResult));
            }

            foreach (SearchResultItem item in displayOfResults)
            {
                SearchResultsStackPanel.Children.Add(item);    
            }

            
        }

        private List<Image> fakeDataBaseQuery(string query)
        {
            string actualQuery = query.ToLower();
            //actualQuery = actualQuery + ".jpg";

            List<Image> imgagesOfAllItems = GetImagesFromFile();
            List<Image> resultQuery = new List<Image>();

            foreach (Image currImage in imgagesOfAllItems)
            {
                 string currentImageName = currImage.Source.ToString().Split('/').Last();
                 if (currentImageName.Contains(actualQuery))
                 {
                     resultQuery.Add(currImage);
                 }
            }


            return resultQuery;
        }

        private List<Image> GetImagesFromFile(string directory = @"../../Resources/Images/SearchItems")
        {
            //get all the images in the images folder
            List<Image> imageList = new List<Image>();
            List<ImageSource> sourceList = new List<ImageSource>();

            DirectoryInfo dir = new DirectoryInfo(directory);
            FileInfo[] files = dir.GetFiles();

            foreach (var item in files)
            {
                if (item.Extension == ".jpeg" || item.Extension == ".jpg" || item.Extension == ".png")
                {
                    Image img = new Image();
                    img.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(item.FullName);
                    imageList.Add(img);
                    sourceList.Add(img.Source);
                }
            }
            return imageList;
        }

        private void searchBar_Loaded(object sender, RoutedEventArgs e)
        {
            //searchBar.Width = this.Width - 640; //640 = the size of sport chek logo + languange logo + help logo
        }
        #endregion

        #region Automatically Generated Code
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
            // Subscribe to surface window availability events
            ApplicationServices.WindowInteractive += OnWindowInteractive;
            ApplicationServices.WindowNoninteractive += OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable += OnWindowUnavailable;
        }

        /// <summary>
        /// Removes handlers for window availability events.
        /// </summary>
        private void RemoveWindowAvailabilityHandlers()
        {
            // Unsubscribe from surface window availability events
            ApplicationServices.WindowInteractive -= OnWindowInteractive;
            ApplicationServices.WindowNoninteractive -= OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable -= OnWindowUnavailable;
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