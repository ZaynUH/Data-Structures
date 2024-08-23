using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessed_Exercise_4_Task_A_B_C
{
    internal class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;
        private int edgesAdded;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>(); // nodes of in the Graph stored in a linkedList (prebuilt)
        }

        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));        // Adds node to the graph
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            // Checks if graph has a certain node
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveNode(T id)
        {
            // Removes a node from the graph and also removes that node from the adjacent lists of other nodes, along with the paired weights
            GraphNode<T> node = GetNodeByID(id);
            nodes.Remove(node);
            foreach (GraphNode<T> n in nodes)
            {
                LinkedList<T> listN = n.GetAdjList();
                LinkedList<int> listW = n.GetWeights();
                for(int i = 0; i < listN.Count(); i++)
                {
                    if(listN.ElementAt(i).CompareTo(id) == 0)
                    {
                        listN.Remove(id);
                        int weight = listW.ElementAt(i);
                        foreach(int w  in listW)
                        {
                            if(listW.ElementAt(i).CompareTo(weight) == 0)
                            {
                                listW.Remove(w);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public bool IsEmpty()
        {
            // Checks if graph is empty
            if (nodes.Count == 0)
            {
                return true;
            }
            else return false;
        }

        public GraphNode<T> GetNodeByID(T id)
        {
            // Returns the node if it is present in the graph
            if (IsEmpty())
            {
                return null;
            }
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(id) == 0)
                {
                    return n;
                }
            }
            return null;
        }

        public string[] PrintID()
        {
            // prints and returns all the nodes in the format of an array of strings
            string temp = "";
            foreach (GraphNode<T> n in nodes)
            {
                temp += n.ID.ToString() + ",";
            }
            return temp.Split(',');
        }

        public void AddEdge(T from, T to, int weight)
        {
            // adds the second node and weight into the adjacent lists of the first node
            GraphNode<T> fromNode = GetNodeByID(from);
            GraphNode<T> toNode = GetNodeByID(to);

            if (fromNode != null & toNode != null)
            {
                fromNode.AddEdge(toNode, weight);
                edgesAdded++;
            }
        }

        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            // Checks if a node is in another nodes Adjacent list(if node is connected)
            if (!IsEmpty())
            {
                //    LinkedList<T> list = from.GetAdjList();

                //    foreach (T n in list)
                //    {
                //        if (n.CompareTo(to.ID) == 0)
                //        {
                //            return true;
                //        }
                //    }
                //    return false;

                foreach (GraphNode<T> n in nodes)
                {
                    if (n.ID.CompareTo(from.ID) == 0)
                    {
                        if (from.GetAdjList().Contains(to.ID))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public int NumNodes()
        {
            // Returns the number of nodes in the graph
            int count = 0;
            foreach (GraphNode<T> n in nodes)
            {
                count++;
            }
            return count;
        }

        public int NumEdges()
        {
            // returns the amount of edges in the graph
            return edgesAdded;
        }

        public float AVGWeights()
        {
            // returns the average weights of all nodes combined
            double weight = 0;
            foreach(GraphNode<T> n in nodes)
            {
                LinkedList<int> weightList = n.GetWeights();
                if (weightList.Count != 0)
                {
                    weight += weightList.Average();
                }
                
            }
            return (float) weight;
        }

        public float AVGConnectivity()
        {
            // Returns the average of connections between all nodes combined
            if(NumNodes() == 0)
            {
                return 0;
            }
            else return NumEdges() / NumNodes();

        }

        public float DegreeCentrality(T NodeID)
        {
            GraphNode<T> node = GetNodeByID(NodeID);
            LinkedList<T> list = node.GetAdjList();
            int count = 0;
            foreach (T n in list)
            {
                count++;
            }

            return (float)count / (float)(NumNodes() - 1);
        }

        public string MostConnections() 
        {
            // Checks and returns the node with the most amount of nodes in their Adjacent list
            if (NumNodes() == 0)
            {
                return "N/A";
            }
            else
            {
                T mostConnections = nodes.ElementAt(0).ID;

                for (int i = 1; i < NumNodes(); i++)
                {
                    LinkedList<T> edgesBiggest = GetNodeByID(mostConnections).GetAdjList();
                    LinkedList<T> edgesCurrent = nodes.ElementAt(i).GetAdjList();
                    if (edgesCurrent.Count() > edgesBiggest.Count())
                    {
                        mostConnections = nodes.ElementAt(i).ID;
                    }
                }
                return mostConnections.ToString();
            }
        }

        public string DegreeCentralities()
        {
            // Returns the user the has the highest average edge weights with each nodes
            string mostCom = "";
            if (NumNodes() < 2)
            {
                return "N/A";
            }
            else
            {
                for (int i = 0; i < NumNodes() - 1; i++)
                {
                    if (DegreeCentrality(nodes.ElementAt(i).ID) > 0 && DegreeCentrality(nodes.ElementAt(i + 1).ID) > 0)
                    {
                        if (DegreeCentrality(nodes.ElementAt(i).ID).CompareTo(DegreeCentrality(nodes.ElementAt(i + 1).ID)) < 0)
                        {
                            mostCom = nodes.ElementAt(i).ID.ToString();
                        }
                        else mostCom = nodes.ElementAt(i).ID.ToString();
                    }
                }
                return mostCom;
            }
            
        }

        public void BFSAllConnectedUsers(T startID, ref List<T> visited)
        {
            // Breadthe First Seacrh to see All the nodes that can be contacted from one node too all others, through each nodes adjacency list 
            LinkedList<T> adj; 

            Queue<T> toVisit = new Queue<T>();
            toVisit.Enqueue(startID);

            while (toVisit.Count != 0)
            {
                
                T currentID = toVisit.Dequeue();

                visited.Add(currentID);

                adj = GetNodeByID(currentID).GetAdjList(); 

                foreach (T neighbor in adj)
                {
                    if (!visited.Contains(neighbor) && !toVisit.Contains(neighbor))
                    {
                        toVisit.Enqueue(neighbor);
                    }
                }
            }
        }
    }
}
