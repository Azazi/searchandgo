using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace SearchAndGo
{
    class DataBaseItem
    {        
        /// <summary>
        /// Product Name
        /// </summary>
        public string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }
        private string _name;

        /// <summary>
        /// Product Price
        /// </summary>
        public double Price
        {
            set { this._price = value; }
            get { return this._price; }
        }
        private double _price;

        /// <summary>
        /// Product Departments
        /// </summary>
        public List<string> Departments = new List<string>();

        /// <summary>
        /// Product Brand
        /// </summary>
        public string Brand
        {
            set { this._brand = value; }
            get { return this._brand; }
        }
        private string _brand;

        /// <summary>
        /// Product Available Colors
        /// </summary>
        public List<string> Colors = new List<string>();

        /// <summary>
        /// Product Available Sizes
        /// </summary>
        public List<string> Sizes = new List<string>();

        /// <summary>
        /// Product Available Inventory
        /// </summary>
        public int Inventory
        {
            set { this._inventory = value; }
            get { return this._inventory; }
        }
        private int _inventory;

        /// <summary>
        /// Product Information
        /// </summary>
        public string ProductInfo
        {
            set { this._productInfo = value; }
            get { return this._productInfo; }
        }
        private string _productInfo;

        /// <summary>
        /// Product Image
        /// </summary>
        public Image ProductImage
        {
            set { this._productImage = value; }
            get { return this._productImage; }
        }
        private Image _productImage;

        /// <summary>
        /// Product Reviews
        /// </summary>
        public List<ReviewItem> Reviews = new List<ReviewItem>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Product name</param>
        /// <param name="price">Product price</param>
        /// <param name="department">List of departments</param>
        /// <param name="brand">Product brand</param>
        /// <param name="colors">Available colors</param>
        /// <param name="sizes">Available sizes</param>
        /// <param name="inventory">Available inventory</param>
        /// <param name="productInfo">Product information</param>
        /// <param name="image">Product image</param>
        /// <param name="reviews">Product reviews</param>
        public DataBaseItem(string name,
                            double price,
                            string department, 
                            string brand, 
                            List<string> colors, 
                            List<string> sizes, 
                            int inventory, 
                            string productInfo,
                            Image image, 
                            List<ReviewItem> reviews)
        {
            this._name = name;
            this._price = price;
            Departments.Add(department);
            this._brand = brand;
            foreach (string color in colors){Colors.Add(color);}
            foreach (string size in sizes) { Sizes.Add(size); }
            this._inventory = inventory;
            this._productInfo = productInfo;
            this._productImage.Source = image.Source;
            foreach (ReviewItem reviewItem in reviews) { Reviews.Add(reviewItem); }
        }
    }
}
