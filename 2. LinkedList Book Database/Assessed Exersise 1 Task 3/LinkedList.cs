using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exersise_1_Task_3
{
    internal class LinkList
    {
        public Book head = null; //default value – empty list

        public void AddToHead(Book book) //add item to front of list
        {
            book.Next = head;
            head = book;
        }

        public string[] DisplayItems() //write items to string and return
        {
            Book temp = head;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                if (temp.Next == null)
                {
                    buffer += temp.Code + ": " + temp.Title + " by " + temp.Author;
                }
                else buffer += temp.Code + ": " + temp.Title + " by " + temp.Author + "\n";

                temp = temp.Next;
            }
            string[] items = buffer.Split('\n');
            return items;
        }

        public int NumberOfItems() // returns number of items in list
        {
            Book temp = head;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public bool Contains(string titleOrID)
        {
            Book temp = head;
            while (temp != null) // move one link and add head to the buffer
            {
               if(temp.Code.ToString().CompareTo(titleOrID) == 0 || temp.Title.ToString().CompareTo(titleOrID) == 0)
               {
                    return true;
               }
               else temp = temp.Next;
            }
            return false;
        }

        public void AppendItem(string title, string author, string ISBN)
        {
            Book temp = head;
            Book newItem = new Book(title, author, ISBN);

            if (head == null)
            {
                head = newItem;
                return;
            }

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newItem;
        }
        public void RemoveItem(string book)// remove occurrences of item from the list
        {
            string ISBN = Peak(book);
            Book temp = head;
            LinkList newList = new LinkList();
            while (temp != null)
            {
                if (ISBN.CompareTo(temp.Code) != 0)
                {
                    newList.AppendItem(temp.Title, temp.Author, temp.Code);
                }
                temp = temp.Next;
            }
            head = newList.head;
        }
        public string Peak(string book)
        {
            int index = book.IndexOf(":");
            string Code = book.Substring(0, index);
            return Code;
        }
    }
}
