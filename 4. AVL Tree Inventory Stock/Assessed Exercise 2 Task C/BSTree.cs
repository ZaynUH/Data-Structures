using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_2_Task_C
{
    internal class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item, int q)
        {
            insertItem(item, q,  ref root);
        }

        private void insertItem(T item, int q, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item, q);
            }
            else if (item.CompareTo(tree.Data) == 0)
            {
                tree.Quantity += q;
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, q, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, q, ref tree.Right);
            }

        }

        private Node<T> max(Node<T> x, Node<T> y)
        {
            if (x.Data.CompareTo(y.Data) > 0)
            {
                return x;
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
        protected int height(Node<T> temp)
        {
            if (temp == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(height(temp.Left), height(temp.Right));
            }

        }

        //public Node<T> GetNode(T item)
        //{
        //    return getNode(item, ref root);
        //}
        //private Node<T> getNode(T item, ref Node<T> tree)
        //{
        //    if (item.CompareTo(tree.Data) < 0)
        //    {
        //        return getNode(item, ref tree.Left);
        //    }
        //    else if (item.CompareTo(tree.Data) > 0)
        //    {
        //        return getNode(item, ref tree.Right);
        //    }
        //    else
        //    {
        //        return tree;
        //    }
        //}

        //public void PrintNode(T item)
        //{
        //    Node<T> node = GetNode(item);

        //    Console.WriteLine("Node: " + node.Data);
        //    if (node.Right == null)
        //    {
        //        Console.WriteLine("Right: Node: Null");
        //    }
        //    else if (node.Right != null)
        //    {
        //        Console.WriteLine("Right: Node: " + node.Right.Data);
        //    }

        //    if (node.Left == null)
        //    {
        //        Console.WriteLine("Left: Node: Null");
        //    }
        //    else if (node.Left != null)
        //    {
        //        Console.WriteLine("Left: Node: " + node.Left.Data);
        //    }
        //}

        public void RemoveItem(T item, int q)
        {
            removeItem(item, q,ref root);
        }
        private void removeItem(T item, int q, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = null;
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, q, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                removeItem(item, q, ref tree.Right);
            }
            else if (item.CompareTo(tree.Data) == 0)
            {
                if ((tree.Quantity - q) == 0)
                {
                    if (tree.Left == null & tree.Right != null)
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
                        removeItem(newRoot, q, ref tree.Right);
                    }
                    else if (tree.Right == null & tree.Left == null)
                    {
                        tree = null;
                    }
                }
                else if ((tree.Quantity - q) > 0)
                {
                    tree.Quantity -= q;
                }
                else if ((tree.Quantity - q) < 0)
                {
                    Console.WriteLine("Quantity removed from " + tree.Data + " exceeds quantity in stock");
                }
            }
        }

        private string[] PrintItems()
        {
            string temp = "";
            this.InOrder(ref temp);

            string[] list = temp.Split(',');
            return list;

        }

        public void PrintProducts(ref string[] items, ref string[] quantities)
        {
            string tempP = "";
            string tempQ = "";
            PreOrder(ref tempP, ref tempQ);

            string[] p = tempP.Split(',');
            string[] q = tempQ.Split(',');

            items = p;
            quantities = q;
        }

        public int Count()
        {
            return PrintItems().Count() - 1;
        }

        public bool Contains(T item)
        {
            string[] products = PrintItems();

            foreach(string product in products)
            {
                if (product.CompareTo(item) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //public bool Equals(BSTree<T> newTree)
        //{
        //    if (newTree.PrintNodes() == this.PrintNodes())
        //    {
        //        return true;

        //    }
        //    else return false;
        //}

        public T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else
            {
                return leastItem(tree.Left);
            }
        }
    }
}
