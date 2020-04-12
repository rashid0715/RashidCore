using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RashidCore.BookStore.Controllers.Tutorials
{
    public class BSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Layout()
        {
            return View();
        }
        public IActionResult Grid()
        {
            return View();
        }

        public IActionResult Media()
        {
            return View();
        }

        public IActionResult TypoGraphy()
        {
            return View();
        }
        public IActionResult Position()
        {
            return View();
        }

        public IActionResult Display()
        {
            return View();
        }
    }
}