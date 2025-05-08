using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliographical_Inheritance
{
    internal class Book : Resource
    {
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(string author, string title, string category, int pagecount): base (title, category)
        {
            Author = author;
            PageCount = pagecount;
        }
    }
}
