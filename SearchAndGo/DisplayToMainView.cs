﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace SearchAndGo
{
    static class DisplayToMainView
    {
        public static void displayInContentArea(WrapPanel panel, List<SearchResultItem> aList)
        {
            panel.Children.Clear();
            foreach (SearchResultItem item in aList)
            {
                panel.Children.Add(item);
            }
        }

        public static void displayInContentArea(WrapPanel panel, SearchResultItem anItem)
        {
            panel.Children.Clear();
            panel.Children.Add(anItem);
        }

        public static void displayInContentArea(WrapPanel panel, CategoryBrowser anItem)
        {
            panel.Children.Clear();
            panel.Children.Add(anItem);
        }

        public static void displayInContentArea(WrapPanel panel, List<CategoryBrowser> aList)
        {
            panel.Children.Clear();
            foreach (CategoryBrowser item in aList)
            {
                panel.Children.Add(item);
            }
        }
    }
}