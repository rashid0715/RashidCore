using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RashidCore.BookStore.Controllers.Tutorials
{
    public class LinqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult abc()
        {
            return View();
        }
    }
}