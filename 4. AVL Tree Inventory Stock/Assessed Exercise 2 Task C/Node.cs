using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_2_Task_C
{
    internal class Node<T> where T : IComparable
    {
        private T data;
        private int quantity;
        public Node<T> Left, Right;
        private int balanceFactor;

        public Node(T data, int quantity)
        {
            this.data = data;
            this.Left = null;
            this.Right = null;
            this.balanceFactor = 0;
            this.quantity = quantity;
        }

        public T Data
        {
            set { data = value; }
            get { return data; }
        }

        public int Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }

        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }
    }
}
