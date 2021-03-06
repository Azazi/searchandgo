﻿using System;
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
    /// Interaction logic for CategoryBrowser.xaml
    /// </summary>
    public partial class CategoryItem : UserControl
    {
        SearchResultItem containedItem;
        public CategoryItem(SearchResultItem anItem)
        {
            InitializeComponent();
            containedItem = anItem;
            categoryName.Content = anItem.category.ToUpper();
            Image im = new Image();
            im.Source = anItem.backgroundImage.Source;
            categoryButton.Content = im;
            categoryButton.Click += new RoutedEventHandler(mainButton_Click);
        }

        void mainButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayToMainView.displayInContentArea(SearchAndGo.MainWindow.getMain(), FakeDB.fakeDataBaseQuery(containedItem.category));
        }
    }
}
