using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RashidCore.BookStore.Models.Tutorials;

namespace RashidCore.BookStore.Controllers.Tutorials
{
    public class LinqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string    abc()
        {
            string strReturnString = "";

            List<EmployeeLocal> lstEmployeesLocal = new List<EmployeeLocal>()
            {
                new EmployeeLocal(){Id=101,strName="rashid",strEmail="rashidem@gmail.com"},
                new EmployeeLocal(){Id=102,strName="arshad",strEmail="arshad420@gmail.com"},
                new EmployeeLocal(){Id=103,strName="tauseef",strEmail="tauseef300@gmail.com"},
                new EmployeeLocal(){Id=104,strName="amit",strEmail="amitnanda@gmail.com"},
                new EmployeeLocal(){Id=105,strName="negi",strEmail="negimohi@gmail.com"}
            };

            #region SELECT DATA USING SIMPLE QUERY
            strReturnString = "Select Using Simple Query";
            //var strBasicQuery = (from emp in lstEmployeesLocal
            //                     select emp).ToList();

            //foreach (var e in strBasicQuery)
            //{
            //    strReturnString += "\nId: " + e.Id + "   **   Name: " + e.strName + "   **   Email: " + e.strEmail;

            //}

            #endregion


            #region SELECT DATA USING SIMPLE METHOD
            strReturnString = "Select Using Simple Method";

            //this will simply fetch all records.
            var strBasicMethod = lstEmployeesLocal.Where(x=>x.Id==103).ToList();

            foreach (var e in strBasicMethod)
            {
                strReturnString += "\nId: " + e.Id + "   **   Name: " + e.strName + "   **   Email: " + e.strEmail;

            }

            #endregion

            return strReturnString;
            // return View();
        }

    }
}