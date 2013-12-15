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
    /// Interaction logic for FindAtOtherLocation.xaml
    /// </summary>
    public partial class FindAtOtherLocation : Window
    {
        public FindAtOtherLocation()
        {
            InitializeComponent();
        }

        private void South_Click(object sender, RoutedEventArgs e)
        {
            if (mapToSouthcenter.Height != 0)
            {
                mapToSouthcenter.Height = 0;
                mapToSouthcenter.Width = 0;
            }
            else
            {
                mapToSouthcenter.Height = 642;
                mapToSouthcenter.Width = 642;
                mapToSouthcenter.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"../../Resources/Images/imageMapToSouthCenter.png");
            }
        }

        private void Market_Click(object sender, RoutedEventArgs e)
        {
            if (mapToMarket.Height != 0)
            {
                mapToMarket.Height = 0;
                mapToMarket.Width = 0;
            }
            else
            {
                mapToMarket.Height = 642;
                mapToMarket.Width = 642;
                mapToMarket.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"../../Resources/Images/imageMapToMarketMall.png");
            }
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
