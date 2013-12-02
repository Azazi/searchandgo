using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchAndGo
{
    class ReviewItem
    {
        /// <summary>
        /// Review Title
        /// </summary>
        public string Title
        {
            set { this._title = value; }
            get { return this._title; }
        }
        private string _title;

        /// <summary>
        /// Review Rating
        /// </summary>
        public double Rating
        {
            set { this._rating = value; }
            get { return this._rating; }
        }
        private double _rating;

        /// <summary>
        /// Review Comment
        /// </summary>
        public string Comment
        {
            set { this._comment = value; }
            get { return this._comment; }
        }
        private string _comment;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Review title</param>
        /// <param name="rating">Review rating</param>
        /// <param name="comment">Review comment</param>
        public ReviewItem(string title, double rating, string comment)
        {
            this._title = title;
            this._rating = rating;
            this._comment = comment;
        }
    }
}
