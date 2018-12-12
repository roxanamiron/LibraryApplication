using System;
using LibraryApplication.Domain.Entities;
using System.Data.Entity;

namespace LibraryApplication.Domain.Repository
{
    public class BooksDbRepository : BaseRepository<Book>, IBookRepository
    {
        public BooksDbRepository(DbContext context) : base(context)
        {

        }
    }
}