using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RashidCore.BookStore.Controllers.Tutorials
{
    public class MVCController : Controller
    {
        public IActionResult MVCIndex()
        {
            return View();
        }

        public IActionResult ViewBagViewData()
        {
            return View();
        }
    }
}