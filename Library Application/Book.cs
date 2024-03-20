using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Application
{
    public class Book : IComparable<Book>
    {
        public int ISBN { get; set; } // ISBN number of the book
        public string Title { get; set; } // Title of the book
        public string Author { get; set; } // Author of the book

        public Book(int isbn, string title, string author)
        {
            ISBN = isbn; // Initialize ISBN
            Title = title; // Initialize Title
            Author = author; // Initialize Author
        }

        // Implement the CompareTo method of the IComparable<Book> interface
        public int CompareTo(Book other)
        {
            // Compare books based on their ISBN
            return ISBN.CompareTo(other.ISBN);
        }

    }
}
