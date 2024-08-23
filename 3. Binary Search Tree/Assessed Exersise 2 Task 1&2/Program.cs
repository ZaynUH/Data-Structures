using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assessed_Exersise_2_Task_1_2
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            // initialise Menu and BS Tree
            Menu myMenu = new Menu();

            BSTree<string> tree = new BSTree<string>();
            // Pre Inserted tree Values
            tree.InsertItem("4");
            tree.InsertItem("1");
            tree.InsertItem("5");
            tree.InsertItem("2");
            tree.InsertItem("3");

            myMenu.MenuSetUp(tree);
        }

        
    }
}
