using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using LibraryApplication.Domain.Entities;
using System.Threading.Tasks;
using LibraryApplication.Repository.Entities;

namespace LibraryApplication.Controllers
{
    public class BooksController : Controller
    {
        public static List<Book> _booksList;

        public async Task<ActionResult> Retrive(string searchTerm, int? page)
        {
            Counter counter = await API_Services.ApiServices.GetBooksNumber();
            // 
            for (int i = 1; i < counter.totalItems; i++)
            {

                // call APIServices.getBooks for each page  
                var books = await API_Services.ApiServices.GetBooks(searchTerm, i);

                if (i == page - 1)
                {
                    if (page == null)
                    {
                        return View("PageNotFount");
                    }
                    Console.WriteLine("This is the last page");
                }
            }
            return View();
        }



        static BooksController()
        {
            List<Book> books = new List<Book>();
            Book book = new Book()
            {
                BookId = 1,
                Title = "Pappilon",
                Publisher = "Henri Charriere",
                StartYear = 1970,
                EndYear = 2010
            };
            books.Add(book);
            book = new Book()
            {
                BookId = 2,
                Title = "Pride and Prejudice",
                Publisher = "Jane Austen",
                StartYear = 1813,
                EndYear = 2000
            };
            books.Add(book);
            book = new Book()
            {
                BookId = 1,
                Title = "Fluturi",
                Publisher = "Irina binder",
                StartYear = 2000,
                EndYear = 2010
            };
            books.Add(book);
            BooksController._booksList = books;
        }

        public BooksController()
        {
        }

        public ActionResult Create()
        {
            return base.View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ActionResult action;
            try
            {
                action = base.RedirectToAction("Index");
            }
            catch
            {
                action = base.View();
            }
            return action;
        }

        public ActionResult Delete(int id)
        {
            return base.View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            ActionResult action;
            try
            {
                action = base.RedirectToAction("Index");
            }
            catch
            {
                action = base.View();
            }
            return action;
        }

        public ActionResult Details(int id)
        {
            return base.View();
        }

        public ActionResult Edit(int id)
        {
           
            Book books = BooksController._booksList.Single<Book>((Book r) => r.BookId == id);
            return base.View(books);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            ActionResult action;
           
            Book books = BooksController._booksList.Single<Book>((Book r) => r.BookId == id);
            if (!base.TryUpdateModel<Book>(books))
            {
                action = base.View(books);
            }
            else
            {
                action = base.RedirectToAction("Index");
            }
            return action;
        }

        public ActionResult Index()
        {
            IOrderedEnumerable<Book> booksList =
                from b in BooksController._booksList
                orderby b.Title
                select b;

            var books = MvcApplication.BookRepository.GetAll();

            return base.View(books);
        }
    }
}