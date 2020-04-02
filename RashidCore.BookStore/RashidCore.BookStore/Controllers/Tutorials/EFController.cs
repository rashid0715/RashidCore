using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RashidCore.BookStore.Controllers.Tutorials
{
    public class EFController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string abc()
        {
            return "abc";
        }
    }
}