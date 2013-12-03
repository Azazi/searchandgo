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

namespace SearchAndGo
{
    /// <summary>
    /// Interaction logic for SearchResultItem.xaml
    /// </summary>
    public partial class SearchResultItem : UserControl
    {
        public Image backgroundImage;
        public string category;
        public string brand;
        public string price;
        public string name;
        public string rawName;

        public SearchResultItem(Image image)
        {
            InitializeComponent();
            backgroundImage = image;
            parseName(image.Source.ToString().Split('/').Last());

            itemName.Content = this.name.ToUpper();
            mainButton.Content = backgroundImage;
            mainButton.Click += new RoutedEventHandler(mainButton_Click);
        }

        void mainButton_Click(object sender, RoutedEventArgs e)
        {
            ItemWindow itemWindow = new ItemWindow(backgroundImage);
            itemWindow.Show();
        }

        //Name of images should be in the following format
        //category-brand-price-name.jpg
        public void parseName(string rawName)
        {
            this.rawName = rawName.Split('.')[0];
            try
            {
                string[] nameSplitByDashes = rawName.Split('-');
                this.category = nameSplitByDashes[0].ToLower();
                this.brand = nameSplitByDashes[1].ToLower();
                this.price = nameSplitByDashes[2];
                this.name = nameSplitByDashes[3].Split('.')[0].ToLower();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("In SeachResultItem.xaml.cs line 55" + e.Message);
            }
        }
    }
}
