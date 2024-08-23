using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exersise_2_Task_1_2
{
    internal class Node<T> where T : IComparable
    {
        private T data;
        public Node<T> Left, Right;

        public Node(T data)
        {
            this.data = data;
            this.Left = null;
            this.Right = null;
        }

        public T Data
        {
            set { data = value; }
            get { return data; }

        }
    }
}
