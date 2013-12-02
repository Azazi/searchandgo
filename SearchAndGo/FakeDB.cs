using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using System.Windows;

namespace SearchAndGo
{
    class FakeDB
    {
        public static List<SearchResultItem> searchWithinCategory(string query, string category)
        {
            List<SearchResultItem> returnList = new List<SearchResultItem>();
            string filteredQuery = query.ToLower();
            string filteredCategory = category.ToLower();
            foreach (SearchResultItem item in fakeDataBaseQuery(filteredCategory))
            {
                string itemsRawName = item.rawName;
                if (itemsRawName.Contains(filteredQuery))
                {
                    returnList.Add(item);
                }
            }
            return returnList;
        }

        public static List<SearchResultItem> convertToItems(List<Image> aList)
        {
            List<SearchResultItem> returnList = new List<SearchResultItem>();
            foreach (Image currImage in aList)
            {
                returnList.Add(new SearchResultItem(currImage));
            }
            return returnList;
        }

        public static List<SearchResultItem> fakeDataBaseQuery(string query)
        {
            string actualQuery = query.ToLower();
            List<SearchResultItem> allItems = convertToItems(GetImagesFromFile());
            List<SearchResultItem> results = new List<SearchResultItem>();
            foreach (SearchResultItem currItem in allItems)
            {
                if (currItem.name.Contains(actualQuery) || currItem.brand.Contains(actualQuery) || currItem.category.Contains(actualQuery))
                {
                    results.Add(currItem);
                }
            }
            return results;
        }

        public static List<string> getAllCategories()
        {
            List<Image> imgagesOfAllItems = GetImagesFromFile();
            List<SearchResultItem> allItems = convertToItems(imgagesOfAllItems);
            List<string> returnList = new List<string>();
            foreach (SearchResultItem currItem in allItems)
            {
                if (!returnList.Contains(currItem.category.ToLower()))
                {
                    returnList.Add(currItem.category);
                }
            }
            return returnList;
        }

        public static List<Image> GetImagesFromFile(string directory = @"../../Resources/Images/SearchItems")
        {
            //get all the images in the images folder
            List<Image> imageList = new List<Image>();
            List<ImageSource> sourceList = new List<ImageSource>();

            DirectoryInfo dir = new DirectoryInfo(directory);
            FileInfo[] files = dir.GetFiles();

            foreach (var item in files)
            {
                if (item.Extension == ".jpeg" || item.Extension == ".jpg" || item.Extension == ".png")
                {
                    Image img = new Image();
                    img.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(item.FullName);
                    imageList.Add(img);
                    sourceList.Add(img.Source);
                }
            }
            return imageList;
        }
    }
}
