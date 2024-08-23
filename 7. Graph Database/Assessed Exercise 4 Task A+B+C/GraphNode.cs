using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_4_Task_A_B_C
{
    internal class GraphNode<T> where T : IComparable
    {
        private T Id;

        private LinkedList<T> adjacentList;

        private LinkedList<int> weights;

        public GraphNode(T d)
        {
            adjacentList = new LinkedList<T>();
            Id = d;
            weights = new LinkedList<int>();
        }

        public T ID
        {
            set { this.Id = value; }
            get { return Id; }
        }

        public LinkedList<T> GetAdjList()
        {
            return adjacentList;        // return linkedlist of connected nodes
        }

        public LinkedList<int> GetWeights()
        {
            return weights;     // return linkedlist of connected nodes edge weights
        }


        public void AddEdge(GraphNode<T> to, int weight)
        {
            adjacentList.AddLast(to.ID);        // Adds a node and weight to the currents nodes linkedLists
            weights.AddLast(weight);
        }

        public int CompareTo(object obj)    // Comapres ID of each Node
        {
            GraphNode<T> other = (GraphNode<T>)obj;
            return this.Id.CompareTo(other.Id);
        }
    }
}
