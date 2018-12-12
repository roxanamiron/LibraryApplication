using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class BooksReviews
    {
        public int Id { get; set; }        
        public int Rating { get; set; }
        public string Body { get; set; }
        public int BooksId { get; set; }

    }
}