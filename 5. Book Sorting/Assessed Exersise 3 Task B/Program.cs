using Assessed_Exersise_3_Task_B.Week_7_Sort_Algorithms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assessed_Exersise_3_Task_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

        static public void Menu()
        {
            //  Menu to Choose option
            Console.WriteLine("Sorter using Selection Sort\n");
            Console.WriteLine("What would you like to sort: ");
            Console.WriteLine("1. Books \n2. Integers");
            string choice = Console.ReadLine();

            Console.WriteLine("\nSize of list: ");
            string numOfItems = Console.ReadLine();
            bool isNumber = int.TryParse(numOfItems, out int items);        // Gets the number of items for Array
            if(isNumber == false)   // checks if number
            {
                Console.WriteLine("\nPlease enter a correct Integer\n");    // error message
                Menu();
            }
            if(choice == "1" ||choice == "Books")
            {
                Book[] bookList = new Book[items];          // lists a created whether Book or integer is chosen
                BookMenu(bookList);
            }
            else if(choice == "2" || choice == "Integers")
            {
                int[] numList = new int[items];
                IntegerMenu(numList);
            }
            else
            {
                Console.WriteLine("\nPlease enter a correct option. \n");   // error message
                Menu();
            }
           
        }
        static public void BookMenu(Book[] bookList)
        {
            string tempTitle;
            string tempAuthor;
            string tempPubDate;

            Console.WriteLine("\nAdd Books to the List\n");

            for (int i = 0; i < bookList.Length; i++)
            {
                bool check = false;

                    Console.WriteLine("Book " + (i + 1));
                    Console.WriteLine("Book Name: ");
                    tempTitle = Console.ReadLine();
                    Console.WriteLine("Author Name: ");         // Gets the Book details
                    tempAuthor = Console.ReadLine();
                do
                {
                    Console.WriteLine("Publication Date: ");
                    tempPubDate = Console.ReadLine();

                    check = Regex.IsMatch(tempPubDate, @"^\d{4}$");

                } while (check == false);

                Console.WriteLine(tempTitle + " by " + tempAuthor + ". " + tempPubDate + " added to list");
                Book tempBook = new Book(tempTitle, tempAuthor, Convert.ToInt32(tempPubDate));  // Adds to the Array
                bookList[i] = tempBook;
            }

            SortMenu(bookList);     // Sort

        }
        static public void IntegerMenu(int[] numList)
        {
            string tempNum;
            Console.WriteLine("\nAdd Integers to the List\n");

            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine("Integer " + (i + 1));    // Gets integers
                tempNum = Console.ReadLine();

                Console.WriteLine(tempNum + " added to list");      // Adds to the array
                numList[i] = Convert.ToInt32(tempNum);
            }

            SortMenu(numList);  // Sort

        }
        static public void SortMenu<T>(T[] list) where T : IComparable
        {
            Console.WriteLine("\nList before Sort:\n");
            for(int i = 0; i < list.Length; i ++)
            {
                Console.WriteLine(list[i].ToString());      // Outputs before sort
            }

            SelectionSort(list);    //SelectionSort

            Console.WriteLine("\nList after Sort:\n");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].ToString());      // Outputs after Sort
            }
            if(list is Book[])
            {
                Console.WriteLine("\nSorted by Book Title\n");
            }
            else
            {
                Console.WriteLine("\nSorted All Integer\n");
            }
            

            Menu();
        }

        static public void SelectionSort<T>(T[] list) where T : IComparable
        {
            for (int i = 0; i < list.Length; i++)
            { 
                int smallest = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list [j].CompareTo(list[smallest]) < 0)
                    {
                        smallest = j;               
                    }
                }
                swap(ref list[i], ref list[smallest]);
            }
        }
        static public void swap<T>(ref T x, ref T y) where T : IComparable
        {
            T temp = x;
            x = y;              // Swaps two Variables
            y = temp;
        }
    }
}
