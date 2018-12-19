using System;
using LibraryApplication.Domain.Entities;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace LibraryApplication.Domain.Repository
{
    public class BooksDbRepository : BaseRepository<Book>, IBookRepository
    {
        public string Title { get; private set; }
       
        public BooksDbRepository(DbContext context) : base(context)
        {

        }
        public static void SaveBooks(Book book)
        {
            var type = book.GetType();

            var properties = book.GetType().GetProperties();
            Console.WriteLine("Finding properties for {0} ", type.Name);
            foreach (var property in properties)
            {
                var atributes = property.GetCustomAttributes(false);
                string message = "The {0} property saved to the {1} DB";
                var columnSaved = atributes
                    .FirstOrDefault(b => b.GetType() == typeof(BooksDbRepository));
                if (columnSaved != null)
                {
                    var saved = columnSaved as BooksDbRepository;
                    Console.WriteLine(message, property.Name, saved.Title);
                }
                
            }
        }
       

       
    }
}