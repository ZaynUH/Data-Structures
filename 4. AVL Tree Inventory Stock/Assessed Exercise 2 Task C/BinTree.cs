using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_2_Task_C
{
    internal class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree()
        {
            root = null;
        }
        public BinTree(Node<T> data)
        {
            root = data;
        }

        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }
        }

        public void PreOrder(ref string buffer, ref string quantities)
        {
            preOrder(root, ref buffer, ref quantities);
        }

        private void preOrder(Node<T> tree, ref string products, ref string quantities)
        {
            if (tree != null)
            {
                products += tree.Data.ToString() + ",";
                quantities += tree.Quantity.ToString() + ",";
                preOrder(tree.Left, ref products, ref quantities);
                preOrder(tree.Right, ref products, ref quantities);
            }

        }
        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }

        }
    }
}
