using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task8
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
        }

        public Book(string title)
        {
            Title = title;
            Author = "Unknown";
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    // Q: How does constructor overloading improve class usability?
    // A: It provides flexibility for creating objects with different sets of information. 
    //    Users can initialize objects with default, partial, or full data.

}
