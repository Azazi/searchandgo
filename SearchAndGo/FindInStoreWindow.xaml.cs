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
using System.Windows.Shapes;

namespace SearchAndGo
{
    /// <summary>
    /// Interaction logic for FindInStoreWindow.xaml
    /// </summary>
    public partial class FindInStoreWindow : Window
    {
        //Image map;
        public FindInStoreWindow()
        {
            InitializeComponent();

            CenterWindowOnScreen();

            closeButton.Click += new RoutedEventHandler(closeButton_Click);
        }

        public FindInStoreWindow(Image image)
        {
            InitializeComponent();

            CenterWindowOnScreen();

            closeButton.Click += new RoutedEventHandler(closeButton_Click);

            this.Dispatcher.Invoke(new Action(delegate()
            {
                map.Source = image.Source;
                windowCanvas.Children.Add(map);
            }));
        }

        void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }
    }
}
