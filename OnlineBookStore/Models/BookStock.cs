using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookStore.Models
{
    /// <summary>
    /// Book attributes 
    /// </summary>
    public class BookStock
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string BookCategory { get; set; }
        public string Edition { get; set; }
        public double Price { get; set; }

    }
}