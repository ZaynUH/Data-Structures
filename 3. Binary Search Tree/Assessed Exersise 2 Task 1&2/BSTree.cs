using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exersise_2_Task_1_2
{
    internal class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);               // Finds a empty Node to insert into the tree
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }

        }

        private Node<T> max(Node<T> x, Node<T> y)
        {
            if (x.Data.CompareTo(y.Data) > 0)
            {
                return x;           // Finds largest value
            }
            else
            {
                return y;
            }
        }

        public int Height()
        {
            return height(root);
        }
        private int height(Node<T> temp)
        {
            if (temp == null)
            {
                return 0;                     // Returns height of tree through recursion
            }
            else
            {
                return 1 + Math.Max(height(temp.Left), height(temp.Right));
            }

        }

        public Node<T> GetNode(T item)
        {
            return getNode(item , ref root);
        }
        private Node<T> getNode(T item, ref Node<T> tree)
        {
            if (item.CompareTo(tree.Data) < 0)
            {
                return getNode(item, ref tree.Left);        // Finds and returns Node if found or null if not
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                return getNode(item, ref tree.Right);
            }
            else
            {
                return tree;
            }
        }

        public void PrintNode(T item)
        {
            Node<T> node = GetNode(item);

            Console.WriteLine("Node: " + node.Data);
            if (node.Right == null)
            {
                Console.WriteLine("Right: Node: Null");
            }
            else if (node.Right != null)
            {
                Console.WriteLine("Right: Node: " + node.Right.Data);           // Prints a Nodes Data, left node and right node
            }

            if (node.Left == null)
            {
                Console.WriteLine("Left: Node: Null");
            }
            else if (node.Left != null)
            {
                Console.WriteLine("Left: Node: " + node.Left.Data);
            }
        }

        //public void RemoveItem(T item)
        //{
        //    removeItem(item, ref root);
        //}
        //private void removeItem(T item, ref Node<T> tree)
        //{
        //    Node<T> node = GetNode(item);
        //    tree = node;
        //    // consider ALL cases
        //    //only right child
        //    if (tree.Left == null & tree.Right != null)
        //    {
        //        tree = tree.Right;
        //    }
        //    else if (tree.Right == null & tree.Left != null)
        //    {
        //        // only left child
        //        tree = tree.Left;
        //    }
        //    else if(tree.Right != null & tree.Left != null)
        //    {
        //        // both child
        //        T newRoot = leastItem(tree.Right);

        //        tree.Data = newRoot;
        //        removeItem(newRoot, ref tree.Right);
        //    }
        //    else if (tree.Right == null & tree.Left == null)
        //    {
        //        tree = null;
        //    }
        //}

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }
        private void removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = null;
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                removeItem(item, ref tree.Right);
            }
            else if (item.CompareTo(tree.Data) == 0)
            {
                if (tree.Left == null & tree.Right != null)             // Removes a Node through finding the node through binary search and if found rebalances tree if tree becomes unbalanced upon removal
                {
                    tree = tree.Right;
                }
                else if (tree.Right == null & tree.Left != null)
                {
                    tree = tree.Left;
                }
                else if (tree.Right != null & tree.Left != null)
                {
                    T newRoot = leastItem(tree.Right);
                    tree.Data = newRoot;
                    removeItem(newRoot, ref tree.Right);
                }
                else if (tree.Right == null & tree.Left == null)
                {
                    tree = null;
                }
            }
        }

        private string[] PrintNodes()
        {
            string temp = "";
            this.InOrder(ref temp);

            string[] list = temp.Split(',');        // Prints all nodes in tree in an array of strings
            return list;

        }

        public int Count()
        {
            return PrintNodes().Count() - 1;        // Returns the number of nodes in tree
        }

        public bool Contains(T item)
        {
            foreach (string listItem in PrintNodes())
            {
                if (item.CompareTo(listItem) == 0)
                {
                    return true;        // Returns true if node is found
                }

            }
            return false;
        }

        public bool Equals(BSTree<T> newTree)
        {
            if (newTree.PrintNodes() == this.PrintNodes())
            {
                return true;            // Returns if another tree is equal to current

            }
            else return false;
        }

        public T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;           // returns left node (Smallest node)
            }
            else
            {
                return leastItem(tree.Left);
            }
        }

    }
}
