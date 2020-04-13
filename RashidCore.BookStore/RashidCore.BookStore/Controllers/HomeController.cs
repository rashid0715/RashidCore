using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RashidCore.BookStore.Repository;
using System.Dynamic;

namespace RashidCore.BookStore.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly BookRepository _bookRepository;
        public HomeController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult Index()
        {
            //Simply access dynamic properties from controller to view
            //The scope of ViewBag is to only the view of current controller
            ViewBag.StrTitle = "Book Home";

            // if we access ViewBag.StrData on view, it will simply print the array but we can not get anonymous types (individual array properties) this way.
            ViewBag.StrData = new { Id = 1, StrName = "Rashid" };

            //In order to access properties of dynanic data object, we have to use ExandoObject. 
            //This is how we can pass anonymous types to view from controller
            dynamic dDataExtender = new ExpandoObject();
            dDataExtender.Id=1;
            dDataExtender.StrName = "Rashid Ansari";
            ViewBag.StrData2 = dDataExtender;

            //see how can we pass an object to View from controller
            ViewBag.oObject = new Models.BookModel() {Id=500,StrTitle="Book-500" };

            //we can also use ViewData[""] to pass values from Controller to View; and also from view to Layout file.
            //Viewdata is type safe for complex objects and we can pass get types of object elements so it will
            //catch compilation errors, if any.
            ViewData["StrTitleFromViewData"] = "This is the Title from ViewData";
            ViewData["oObjectFromViewData"] = new Models.BookModel() {Id=600,intPages=1000,StrTitle="Book Title From ViewData Object(600)" };

            var data = _bookRepository.GetAllBooks();
             return View(data);

            //return View();
        }

        public ViewResult About()
        {
            return View();
        }

          
        public ViewResult Privacy()
        {
            return View();
        }
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult Register()
        {
            return View();
        }


    }
}