using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;
        public Book(string aTitle,string aAuthor,int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        public bool BookMethod()
        {
            if (pages <= 400)
            {
                return true;
            } return false;
        }

    }
}
