using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LibraryApplication.Domain.Repository;

namespace LibraryApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IBookRepository BookRepository { get; set; }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            BookRepository = new BooksDbRepository(new LibraryApplicationDb());
        }
    }
}
