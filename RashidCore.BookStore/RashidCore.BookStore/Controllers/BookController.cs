using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RashidCore.BookStore.Models;
using RashidCore.BookStore.Repository;

namespace RashidCore.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        //data from local list datasource
        //public List<BookModel> GetAllBooks()
        //{
        //    return _bookRepository.GetAllBooks();
        //}


        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }

        public BookModel GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }


        public List<BookModel>SearchBooks(string t, string a)
        {
            return _bookRepository.SearchBooks(t, a);
        }





        public IActionResult Index()
        {
            return View();
        }
    }
}