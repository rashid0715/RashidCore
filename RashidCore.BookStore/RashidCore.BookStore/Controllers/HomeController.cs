using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RashidCore.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
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