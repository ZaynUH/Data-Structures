using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assessed_Exercise_2_Task_C
{
    internal class Program
    {

        public static string divider = "\n==========================================================";
        static void Main(string[] args)
        {
            // Initialises Tree and Insert Products with quantities
            AVLTree<string> tree = new AVLTree<string>();
            tree.InsertItem("Banana", 50);
            tree.InsertItem("Apple", 200);
            tree.InsertItem("Laptop", 100);
            tree.InsertItem("Fridge", 4);
            tree.InsertItem("Tissue Box", 79);

            Menu(tree);

            Console.ReadKey();
        }

        public static void Menu(AVLTree<string> tree)
        {
            // Menu to Choose what to do with AVL Tree
            Console.WriteLine(divider);
            Console.WriteLine("\nAVL Tree Product List\t(All Products are Case Sensitive)\n");
            Console.WriteLine("1. View All Products");
            Console.WriteLine("2. Search Product");
            Console.WriteLine("3. Insert Product");
            Console.WriteLine("4. Remove Product");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewAllMenu(tree);
                break;

                case "2":
                    SearchMenu(tree);
                break;

                case "3":
                    AddProductMenu(tree);
                break;

                case "4":
                    RemoveProductMenu(tree);
                break;
            }
            Menu(tree);     //Loop if wrong input
        }

        public static void ViewAllMenu(AVLTree<string> tree)
        {
            // Outputs all products with their quantities in a specific format
            Console.WriteLine(divider);
            Console.WriteLine("\nAll Products stored in AVL Tree:\n");

            string[] products = { };
            string[] quantities = { };

            tree.PrintProducts(ref products, ref quantities);

            
            Console.WriteLine("Product | Quantity");
            Console.WriteLine("------------------\n");
            for(int i = 0; i < products.Length - 1; i++)
            {
                Console.WriteLine(products[i] + " | " + quantities[i]);
            }
        }

        public static void AddProductMenu(AVLTree<string> tree)
        {
            // Adds a product to the tree with a quantity
            Console.WriteLine(divider);
            Console.WriteLine("\nInserting Product\nType < to return to Menu\n");
            Console.WriteLine("-----------------------------------------------\n");
            string product;
            string quantity;

            Console.WriteLine("Enter Product to Insert:");
            product = Console.ReadLine();

            if (product == "<")         // allows for going back
            {
                Menu(tree);
            }

            do
            {
                Console.WriteLine("Enter Quantity:");       
                quantity = Console.ReadLine();

                if (quantity == "<")        // allows for going back
                {
                    Menu(tree);
                }

            }   while (!Regex.IsMatch(quantity, @"^\d+$"));         // checks if quantity is a digit



            tree.InsertItem(product, Convert.ToInt32(quantity));
            if(tree.Contains(product) == true)
            {
                Console.WriteLine(product + " exists in AVL Tree. Adding " + quantity + " to Product"); // adds quantity to exists node
            }
            else
            {
                Console.WriteLine(quantity + " " + product + " has been Inserted into AVL Tree");       // inserts into tree
            }
           
        }

        public static void RemoveProductMenu(AVLTree<string> tree)
        {
            Console.WriteLine(divider);
            Console.WriteLine("\nRemoving Product\nType < to return to Menu\n");
            Console.WriteLine("-----------------------------------------------\n");
            string product;
            string quantity;

            do
            {
                Console.WriteLine("Enter Product to Remove:");
                product = Console.ReadLine();

                if (product == "<")
                {
                    Menu(tree);
                }

            }   while (tree.Contains(product) == false);

            do
            {
                Console.WriteLine("Enter Quantity:");
                quantity = Console.ReadLine();

                if (quantity == "<")
                {
                    Menu(tree);
                }

            }   while (!Regex.IsMatch(quantity, @"^\d+$")) ;

            tree.RemoveItem(product, Convert.ToInt32(quantity));
            Console.WriteLine(quantity + " " + product + " has been Removed from AVL Tree");
        }

        public static void SearchMenu(AVLTree<string> tree)
        {
            // Returns all the products that match the search index
            Console.WriteLine(divider);
            Console.WriteLine("\nSearch Products stored in AVL Tree\nType < to return to Menu\n");
            Console.WriteLine("-----------------------------------------------\n");
            Console.WriteLine("Enter Product to Search:");
            string searchProduct = Console.ReadLine();

            if(searchProduct == "<")
            {
                Menu(tree);
            }
            string[] productList = { };
            string[] quantityList = { };

            tree.PrintProducts(ref productList, ref quantityList);

            List<string> searchedPList = new List<string>();
            List<string> searchedQList = new List<string>();

            for (int i = 0; i < productList.Length; i++)
            {
                if (productList[i].Contains(searchProduct))
                {
                    searchedPList.Add(productList[i]);
                    searchedQList.Add(quantityList[i]);
                }
            }

            Console.WriteLine("Product | Quantity");
            Console.WriteLine("------------------\n");
            for (int i = 0; i < searchedPList.Count; i++)
            {
                Console.WriteLine(searchedPList[i] + " | " + searchedQList[i]);     // Output
            }
        }
    }
}
