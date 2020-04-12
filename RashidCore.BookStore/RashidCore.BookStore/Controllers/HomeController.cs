using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RashidCore.BookStore.Repository;

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