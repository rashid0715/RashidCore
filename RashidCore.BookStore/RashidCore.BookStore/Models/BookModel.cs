using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RashidCore.BookStore.Models
{
    public class BookModel
    {
        public int Id{ get; set; }
        public string StrTitle { get; set; }
        public string StrAuthor{ get; set; }
        public string StrDescription { get; set; }

        public string StrCategory { get; set; }
        public int intPages { get; set; }
        public string StrLanguage { get; set; }
    }
}
