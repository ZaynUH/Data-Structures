using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exersise_2_Task_1_2
{
    internal class Menu
    {
        string currentMenu = "1";
        string divider = "========================================================";

        public void MenuSetUp(BSTree<string> tree)
        {
            switch (currentMenu)
            {
                case "1":
                    MainMenu(tree);
                    break;
            }

        }

        public void MainMenu(BSTree<string> tree)
        {
            // Menu to Choose what to do with the tree
            Console.WriteLine(divider);
            Console.WriteLine("Tree Menu: \n");
            Console.WriteLine("1. View Tree");
            Console.WriteLine("2. Add a Node to the Tree");
            Console.WriteLine("3. Remove a Node from the Tree");
            Console.WriteLine("4. View a Node");
            Console.WriteLine("5. View additional Info on Tree");
            Console.WriteLine("Enter an option Number: ");
            currentMenu = Console.ReadLine();
            switch (currentMenu)
            {
                case "1":
                    ViewTreeMenu(tree);
                    break;  

                case "2":
                    AddNode(tree);
                    break;

                case "3":
                    RemoveNode(tree);
                    break;

                case "4":
                    PeakNode(tree);
                    break;

                case "5":
                    ViewInfo(tree);
                    break;


            }
            Console.WriteLine(divider);
            MainMenu(tree);
        }

        public void ViewTreeMenu(BSTree<string> tree)
        {
            // Menu to choose what traversal to Output
            Console.WriteLine(divider);
            Console.WriteLine("Tree Views: \n");
            Console.WriteLine("1. Pre-Order Traversal");
            Console.WriteLine("2. In-Order Traversal");
            Console.WriteLine("3. Post-Order Traversal");
            Console.WriteLine("4. Back");
            Console.WriteLine("Enter an option Number: ");
            currentMenu = Console.ReadLine();

            string buffer = "";
            switch (currentMenu)
            {
                case "1":
                    ShowPreOrder(buffer, tree);
                    break;

                case "2":
                    ShowInOrder(buffer, tree); 
                    break;

                case "3":
                    ShowPostOrder(buffer, tree);
                    break;

                case "4":
                    MainMenu(tree);
                    break;
            }
            Console.WriteLine(divider);
            ViewTreeMenu(tree);
        }
        public void ShowPreOrder(string buffer ,BSTree<string> tree)
        {
            // Pre Order Traversal
            tree.PreOrder(ref buffer);
            Console.WriteLine("\nPre-Order Traversal: " + buffer +"\n");
            MainMenu(tree);
        }
        public void ShowInOrder(string buffer, BSTree<string> tree)
        {
            // In Order Traversal
            tree.InOrder(ref buffer);
            Console.WriteLine("\nIn-Order Traversal: " + buffer + "\n");
            MainMenu(tree);
        }
        public void ShowPostOrder(string buffer, BSTree<string> tree)
        {
            // Post Order Traversal
            tree.PostOrder(ref buffer);
            Console.WriteLine("\nPost-Order Traversal: " + buffer + "\n");
            MainMenu(tree);
        }

        public void AddNode(BSTree<string> tree)
        {
            Console.WriteLine("\nEnter a string to insert into Tree: ");    
            string input = Console.ReadLine();
            if(input == "")         // Checks if input is empty
            {
                Console.WriteLine("Enter an item.");
                AddNode(tree);      // Loops Back Function
            }
            else    // If Not
            {
                if (!tree.Contains(input))
                {
                    tree.InsertItem(input);
                    Console.WriteLine("\n" + input + " inserted into Tree.");
                    MainMenu(tree);  // Loops Back
                }
                else
                {
                    Console.WriteLine("Item exists in tree. Try again.");   // error message
                    AddNode(tree);      // Loops Back Function
                }
            }
        }

        public void RemoveNode(BSTree<string> tree)
        {
            Console.WriteLine("\nEnter a string to be removed from Tree: ");
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("Enter an item.");
                RemoveNode(tree);
            }
            else
            {
                if (tree.Contains(input))
                {
                    tree.RemoveItem(input);
                    Console.WriteLine("\n" + input + " removed drom Tree.");
                    MainMenu(tree);
                }
                else
                {
                    Console.WriteLine("Item does not exist in try. Try again.");
                    RemoveNode(tree);
                }
            }
        }

        public void PeakNode(BSTree<string> tree)
        {   
            Console.WriteLine("\nEnter a string to peak in the Tree: ");
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("Enter an item.");
                PeakNode(tree);
            }
            else
            {
                if (tree.Contains(input))
                {
                    tree.PrintNode(input);
                    MainMenu(tree);
                }
                else
                {
                    Console.WriteLine("Item does not exist in try. Try again.");
                    PeakNode(tree);
                }
            }
        }

        public void ViewInfo(BSTree<string> tree)
        {
            Console.WriteLine("\nHeight of Tree: {0}", tree.Height());          // Outputs the height and number of nodes in tree
            Console.WriteLine("Number of nodes in Tree: {0}", tree.Count());
            MainMenu(tree);
        }
    }
}
