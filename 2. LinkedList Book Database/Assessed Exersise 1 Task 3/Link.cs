using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exersise_1_Task_3
{
    internal class Book
    {
        private string ISBN;
        private string bookTitle;
        private string authorName;
        private Book next;

        public Book( string bookT, string authorN, string ISBN) //constructor with an item
        {
            this.bookTitle = bookT;
            this.authorName = authorN;
            this.ISBN = ISBN;
            this.next = null;
        }
        public Book(string bookT, string authorN, string ISBN, Book next) //constructor with an item
        {
            this.bookTitle = bookT;
            this.authorName = authorN;
            this.ISBN = ISBN;
            this.next = next;
        }

        public string Code //property for data
        {
            set { this.ISBN = value; }
            get { return this.ISBN; }
        }
        public string Title //property for data
        {
            set { this.bookTitle = value; }
            get { return this.bookTitle; }
        }
        public string Author //property for data
        {
            set { this.authorName = value; }
            get { return this.authorName; }
        }

        public Book Next //property for next
        {
            set { this.next = value; }
            get { return this.next; }
        }

    }
}
