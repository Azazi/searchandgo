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

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mapToSouthcenter.Height = 700;
            mapToSouthcenter.Width = 700;           
            mapToSouthcenter.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"../../Resources/Images/streetMap.png");
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
