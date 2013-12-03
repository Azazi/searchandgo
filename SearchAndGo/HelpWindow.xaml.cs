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
    /// Interaction logic for HelpPage.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public HelpWindow()
        {
            InitializeComponent();
        }

        // TODO: This will change when changing the UI of the help window
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            HelpUserControl.Visibility = Visibility.Hidden;
        }
    }
}