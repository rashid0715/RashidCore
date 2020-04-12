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
            new BookModel(){Id=101, StrAuthor="Rashid",StrTitle="Mr. James Hook", StrDescription="This is the description for book Id 101. This is the description for book Id 101. This is the description for book Id 101. This is the description for book Id 101. This is the description for book Id 101. This is the description for book Id 101. This is the description for book Id 101. ",
                intPages=123,StrCategory="Action",StrLanguage="English"},

            new BookModel(){Id=102, StrAuthor="Javed",StrTitle="Harry Potter", StrDescription="This is the description for book Id 102.",
            intPages=203,StrCategory="Fantasy",StrLanguage="Spanish"},

            new BookModel(){Id=103, StrAuthor="Ansari",StrTitle="Gaban", StrDescription="This is the description for book Id 103.",
            intPages=80,StrCategory="Classic",StrLanguage="Hindi"},

            new BookModel(){Id=104, StrAuthor="Amit",StrTitle="Bankelal ka kamal", StrDescription="This is the description for book Id 104.",
            intPages=91,StrCategory="Comedy",StrLanguage="Hindi"},

            new BookModel(){Id=105, StrAuthor="Nanda",StrTitle="Junior jii", StrDescription="This is the description for book Id 105.",
            intPages=66,StrCategory="Sci-Fi",StrLanguage="English"}
        };
            return oList;

        }
    }
}
