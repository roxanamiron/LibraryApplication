using LibraryApplication.Domain.Entities;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;

namespace LibraryApplication.Controllers
{
    public class HomeController : Controller
    {
        LibraryApplicationDb _db = new LibraryApplicationDb();

       


        public ActionResult Index(string searchTerm = null, int page = 1 )
        {
            var model =
                _db.Books
                .OrderBy(b => b.Title)
                .Where(b => searchTerm == null || b.Title.StartsWith(searchTerm))
                .Take(7)
                .Select(b => new BookListViewModel
                {
                    Title = b.Title,
                    Publisher = b.Publisher,
                    StartYear = b.StartYear,
                    EndYear = b.EndYear

                } );


            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

    }

}
