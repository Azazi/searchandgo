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
        Image backgroundImage;
        public SearchResultItem(string name, Image image)
        {
            InitializeComponent();
            backgroundImage = image;
            mainButton.Background = new ImageBrush(backgroundImage.Source);
            //mainButton.Content = name;
            //itemDescription.Content = "item description";
            itemName.Content = name;

            mainButton.Click += new RoutedEventHandler(mainButton_Click);
        }

        void mainButton_Click(object sender, RoutedEventArgs e)
        {
            ItemWindow itemWindow = new ItemWindow(backgroundImage);
            itemWindow.Show();
        }

    }
}
