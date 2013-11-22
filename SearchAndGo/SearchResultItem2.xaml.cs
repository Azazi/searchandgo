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
    public partial class SearchResultItem2 : UserControl
    {
        public SearchResultItem2(string name, Image image)
        {
            InitializeComponent();
            mainButton.Background = new ImageBrush(image.Source);
            //mainButton.Content = name;
            //itemDescription.Content = "item description";
            price.Content = "$95.98";
            itemName.Content = name;
        }

    }
}
