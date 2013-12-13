using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SearchAndGo
{
	/// <summary>
	/// Interaction logic for ItemWindow.xaml
	/// </summary>
	public partial class ItemWindow : Window
	{
        /// <summary>
        /// Find in Other Locations Window
        /// </summary>
        FindAtOtherLocation findAtOtherLocation = new FindAtOtherLocation();

        /// <summary>
        /// Find in Store Window
        /// </summary>
        FindInStoreWindow findInStoreWindow = new FindInStoreWindow();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="image"></param>
        public ItemWindow(Image image)
        {
            this.InitializeComponent();            
            // This will be changed when a database item is in use
            productImage.Source = image.Source;
            


            string[] stringarray = (productImage.Source.ToString()).Substring(productImage.Source.ToString().LastIndexOf("/")).Split('-');
            priceLabel.Content = "$" + stringarray[2];

            // TODO: Organize event handler setup in a separate function?
            Window.Deactivated += new EventHandler(Window_Deactivated);
            findInStoreButton.Click += new RoutedEventHandler(findInStoreButton_Click);
            seeOtherLocationsButton.Click += new RoutedEventHandler(seeOtherLocationsButton_Click);
            closeButton.Click += new RoutedEventHandler(closeButton_Click);

            // TODO: Get rid of this!
            addNike();
        }


        #region Event Handling
        void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        void Window_Deactivated(object sender, EventArgs e)
        {
            if(!findAtOtherLocation.IsVisible && !findInStoreWindow.IsVisible)
                this.Hide();
        }

        void seeOtherLocationsButton_Click(object sender, RoutedEventArgs e)
        {
            findAtOtherLocation = new FindAtOtherLocation();
            findAtOtherLocation.Show();
        }

        void findInStoreButton_Click(object sender, RoutedEventArgs e)
        {
            findInStoreWindow = new FindInStoreWindow();
            findInStoreWindow.Show();
        }
        #endregion

        // TODO: Get rid of this!
        void addNike()
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                ImageSource categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i1.jpg");
                Image categoryImage = new Image();
                categoryImage.Source = categorySource;
                SearchResultItem2 newItem = new SearchResultItem2("Nike Zoom Stefan", categoryImage);
                relatedItemsStackPanel.Children.Add(newItem);
                newItem.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Left);
                newItem.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i2.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem2("Nike Dunk Mid", categoryImage);
                relatedItemsStackPanel.Children.Add(newItem);
                newItem.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Left);
                newItem.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i3.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem2("Nike SB Lunar", categoryImage);
                relatedItemsStackPanel.Children.Add(newItem);
                newItem.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Left);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i4.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem2("Nike SB Januski", categoryImage);
                relatedItemsStackPanel.Children.Add(newItem);
                newItem.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Left);

                categorySource = (ImageSource)new ImageSourceConverter().ConvertFromString(@"..\..\Resources\Images\Nike\i5.jpg");
                categoryImage = new Image();
                categoryImage.Source = categorySource;
                newItem = new SearchResultItem2("Nike Project BA", categoryImage);
                relatedItemsStackPanel.Children.Add(newItem);
                newItem.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Left);
            }));
        }
	}
}