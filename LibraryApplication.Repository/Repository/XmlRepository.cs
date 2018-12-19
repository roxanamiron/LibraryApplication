using LibraryApplication.Domain.Entities;
using LibraryApplication.Domain.Repository;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace LibraryApplication.Repository.Repository
{
    public class XmlRepository : IBookRepository
    {

        public static void SaveBooks()
        {

            List<Book> books = new List<Book>();
            books.Add(new Book { Title = "Serialization Overview" });
            System.Xml.Serialization.XmlSerializer save = new System.Xml.Serialization.XmlSerializer(typeof(Book));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            save.Serialize(file, books);
            file.Close();
        }

        public void Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Book> entity)
        {
            throw new NotImplementedException();
        }      

        public IEnumerable<Book> Find(Expression<Func<Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Book entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new NotImplementedException();
        }
    }
}