using System;
using LibraryApplication.Domain.Entities;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace LibraryApplication.Domain.Repository
{
    public class BooksDbRepository : DbRepository<Book>, IBookRepository
    {
        protected readonly DbContext Context;

        public BooksDbRepository(DbContext context) : base(context)
        {
            Context = context;
        }

        
    }
}