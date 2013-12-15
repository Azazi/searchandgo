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
            textBlock1.Visibility = Visibility.Hidden;
            textBlock1_Copy.Visibility = Visibility.Hidden;
            textBlock1_Copy1.Visibility = Visibility.Hidden;
            manualText.Text = readFromFile();
            manualText.FontSize = 25;
        }

        // TODO: This will change when changing the UI of the help window
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            HelpUserControl.Visibility = Visibility.Hidden;
        }

        public string readFromFile(string path = @"../../../README.md")
        {
            string contentsOfFile = "";
            try
            {
                contentsOfFile = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:" + e.Message);
            }
            return contentsOfFile;
        }

        private void repHelp_Click(object sender, RoutedEventArgs e)
        {
            mainScroll.Visibility = Visibility.Hidden;
            manualText.Visibility = Visibility.Hidden;
            textBlock1.Visibility = Visibility.Visible;
            textBlock1_Copy.Visibility = Visibility.Visible;
            textBlock1_Copy1.Visibility = Visibility.Visible;
            repHelp.Visibility = Visibility.Hidden;
        }
    }
}