namespace LibraryApplication.Migrations
{
    using Domain.Entities;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryApplication.LibraryApplicationDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "LibraryApplication.Models.LibraryApplicationDb";
        }

        protected override void Seed(LibraryApplication.LibraryApplicationDb context)
        {
            var books = new List<Book>
            {
                new Book
                {
                    Title = "Red Dragon",
                    Publisher = "Delacorte Press",
                    StartYear = 1999
                },
                new Book
                {
                    Title = "Hannibal",
                    Publisher = "Delacorte Press",
                    StartYear = 1984
                },
                new Book
                {
                    Title = "Hannibal Rise",
                    Publisher = "Delacorte Press",
                    StartYear = 1990,
                    //Reviews =
                    //new List<BooksReviews>
                    //{
                    //    new BooksReviews {Rating = 9, Body = "Great book!!" }
                    //}
            }
            };

           
            for(int i= 0; i < 1000; i++)
            {
                context.Books.AddOrUpdate(b => b.Title,
                    new Book { Title = "Istoria iubirii", Publisher = "Cartpedia", StartYear = 2010 });
            }
           
        }
    }
}
