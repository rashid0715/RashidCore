using RashidCore.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RashidCore.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return BookDataSource();
        }

        public BookModel GetBookById(int id)
        {
            return BookDataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string strTitle, string strAuthor)
        {
            return BookDataSource().Where(x => x.StrTitle.Contains(strTitle) || x.StrAuthor.Contains(strAuthor)).ToList();
        }


        //temp local data
        private List<BookModel> BookDataSource()
        {
            List<BookModel> oList = new List<BookModel>(){
            new BookModel(){Id=101, StrAuthor="Rashid",StrTitle="Mr. James Hook"},
            new BookModel(){Id=102, StrAuthor="Rashid",StrTitle="Harry Potter"},
            new BookModel(){Id=103, StrAuthor="Rashid",StrTitle="Gaban"},
            new BookModel(){Id=104, StrAuthor="Rashid",StrTitle="Bankelal ka kamal"},
            new BookModel(){Id=105, StrAuthor="Rashid",StrTitle="Junior jii"}
        };
            
            return oList;
        }
    }
}
