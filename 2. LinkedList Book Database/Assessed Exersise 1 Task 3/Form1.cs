using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessed_Exersise_1_Task_3
{
    public partial class Form1 : Form
    {
        // Initialise Book LinkList
        LinkList Books = new LinkList();

        public Form1()
        {
            InitializeComponent();
            // Pre-Inserted Books
            Book book1 = new Book("cherub", "Rob much", "1");
            Book book2 = new Book("hunger games", "some", "4");
            Book book3 = new Book("mockbird", "idk", "45");
            
            Books.AddToHead(book1);
            Books.AddToHead(book2);
            Books.AddToHead(book3);
            UpdateBooks();
            
        }

        public void UpdateBooks()
        {
            // Resets the Contents of the BookList ListBox based on if Books are added, removed or searched
            BookStore.Items.Clear();
            string[] books = Books.DisplayItems();
            
            foreach (string item in books)
            {
                BookStore.Items.Add(item);
            }
            AddBookCount();
        }

        public void AddBookCount()
        {
            // Changes the Book Count label
            int index = bookCountLabel.Text.IndexOf(": ");
            string label = bookCountLabel.Text.Substring(0 , index + 2);
            string temp = bookCountLabel.Text.Substring(index + 2);
            int count = Convert.ToInt32(temp);

            string newCount = Convert.ToString(BookStore.Items.Count); 
            bookCountLabel.Text = label + newCount;
        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if(bookTitleTextBox.Text == "" || authorNameTextBox.Text == "" || ISBNCodeTextBox.Text == "")
            {
                outputTextBox.Text = "Enter all fields correctly"; // error message
            }
            else
            {
                if(!Regex.IsMatch(ISBNCodeTextBox.Text, @"^\d+$")) // If ISBN is all digits
                {
                    outputTextBox.Text = "ISBN needs to be all integers";   
                } 
                else
                {
                    if(!Books.Contains(bookTitleTextBox.Text) || !Books.Contains(ISBNCodeTextBox.Text)) // If book already exists
                    {
                        string title = bookTitleTextBox.Text;
                        string author = authorNameTextBox.Text;
                        string code = ISBNCodeTextBox.Text;

                        Book tempBook = new Book(title, author, code);
                        Books.AddToHead(tempBook);                          // Adds book to linked List

                        UpdateBooks();

                        outputTextBox.Text = "Book added";  // Success message
                    }
                    else outputTextBox.Text = "Book exists";        // error message
                }
                bookTitleTextBox.Text = "";     // Clears Text Box
                authorNameTextBox.Text = "";
                ISBNCodeTextBox.Text = "";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BookStore.Items.Count != 0)     // Check if Books Linked List is empty (Through the BookStore ListBox)
            {
                if(BookStore.SelectedItem == null)      // Check if Book is selected in BookStore ListBox
                {
                    outputTextBox.Text = "Select a book";   // error message
                }
                else
                {
                    string item = Convert.ToString(BookStore.SelectedItem);     // Removes Book
                    Books.RemoveItem(item);
                    UpdateBooks();
                    outputTextBox.Text = "Book removed";    // success message
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")   // Checks if TextBox is empty
            {
                outputTextBox.Text = "Search Box Empty";    // error message
            }
            else
            {
                string searchIndex = searchTextBox.Text;    
                LinkList searchedList = new LinkList();
                int count = 0;
                Book temp = Books.head;                                 
                int bookAmount = Books.NumberOfItems() - 1;
                while (count <= bookAmount)                        // Search for book through a Linear Search
                {
                    if (temp.Code.Contains(searchIndex) || temp.Title.Contains(searchIndex) || temp.Author.Contains(searchIndex))   // If any of the Fields have the seachIndex 
                    {
                        Book newbook = new Book(temp.Title, temp.Author, temp.Code);
                        searchedList.AddToHead(newbook);                                // Display the book found
                    }
                    temp = temp.Next;           // If multiple books are found all will be displayed
                    count++;
                }

                BookStore.Items.Clear();            
                string[] books = searchedList.DisplayItems();       // Displays all the Books from the Search in ListBox

                foreach (string item in books)
                {
                    BookStore.Items.Add(item);
                }
                outputTextBox.Text = "All queries for " + searchIndex;      // success message
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            UpdateBooks();                      // Clears the Search Text
            searchTextBox.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void bookTitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
