using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_2_Task_C
{
    internal class AVLTree<T> : BSTree<T> where T : IComparable
    {

        public new void InsertItem(T item, int q)
        {
            insertItem(item, q, ref root);

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
            tree.BalanceFactor = (height(tree.Left) - height(tree.Right));          // If tree is unbalanced the nodes shift based on the balance factor when being inserted

            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            else if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }


        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
            {
                rotateRight(ref tree.Right);        //double rotate
            }

            Node<T> newroot = tree.Right;
            Node<T> oldroot = tree;

            oldroot.Right = newroot.Left;
            newroot.Left = oldroot;
            tree = newroot;

        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)  //double rotate
            {
                rotateLeft(ref tree.Left);
            }

            Node<T> newroot = tree.Left;
            Node<T> oldroot = tree;

            oldroot.Left = newroot.Right;
            newroot.Right = oldroot;
            tree = newroot;

        }
    }
}
