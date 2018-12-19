using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LibraryApplication.Domain.Entities;

namespace LibraryApplication
{
    public class LibraryApplicationDb : DbContext
    {
        public LibraryApplicationDb() : base("name = DefaultConnection")
        {

        }
        public DbSet<Book> Books { get; set; }


        //public DbSet<BooksReviews> Reviews { get; set; }
    }
}