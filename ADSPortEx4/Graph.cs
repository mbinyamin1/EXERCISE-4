using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    //Graph implementation for Assessed Exercise 4

    //Hints : 
    //Use lecture materials from Week 9A
    // and lab sheet 'Lab 9: Graphs Implementation' to aid with base implementation...

    //For 4B, review material from lecture 9B and lab 10 to aid with the implementation of these metrics

    //For 4C, see lecture 10A and lab 10 to aid with your traversal implementation

    //To address the last task for 4C, you can use BFS or DFS to as an idea of how to start off, but remember that we're only
    // interested in loot that can be obtained from the safest possible route, so we don't nessicarily need to find everything on the network as in
    // BFS and DFS!

    // - Adam.M 

    class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;
        private Dictionary<T, int> weightedAdjList = new Dictionary<T, int>();

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        //Functions for EX.4A

        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }

        public GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode<T> current in nodes)
            {
                if (current.ID.CompareTo(id) == 0)
                {
                    return current;
                }
            }
            return null;
        }

        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if (n1 != null && n2 != null)
            {
                n1.AddEdge(n2);
            }

        }

        public int NumNodes()
        {
            return nodes.Count;
        }

        public int NumEdges()
        {
            int count = 0;

            foreach (GraphNode<T> current in nodes)
            {
                count += current.GetAdjList().Count;
                count += current.GetWeightedAdjList().Count;
            }
            return count;
        }

        //Functions for EX.4B

        public void AddWeightedEdge(T from, T to, int weight)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if (n1 != null && n2 != null)
            {
                n1.AddEdgeWithWeight(n2, weight);
            }
        }

        public double AverageOutbound()
        {
            if (nodes.Count == 0) return 0;

            int totalOutbound = 0;

            foreach (GraphNode<T> node in nodes)
            {
                totalOutbound += node.GetAdjList().Count + node.GetWeightedAdjList().Count;
            }

            return (double)totalOutbound / nodes.Count;
        }

        public double AverageWeight()
        {
            int totalWeight = 0;
            int edgeCount = 0;

            foreach (GraphNode<T> node in nodes)
            {
                Dictionary<T, int> weightedEdges = node.GetWeightedAdjList();
                foreach (KeyValuePair<T, int> pair in weightedEdges)
                {
                    totalWeight += pair.Value;
                    edgeCount++;
                }
            }

            return edgeCount > 0 ? (double)totalWeight / edgeCount : 0;
        }

        public List<T> GetAllAdjacencies(T id)
        {
            List<T> adjacents = new List<T>();

            GraphNode<T> node = GetNodeByID(id);

            if (node == null)
            {
                Console.WriteLine("Node not found.");
                return adjacents;
            }

            LinkedList<T> list1 = node.GetAdjList();
            foreach (T item in list1)
            {
                if (!adjacents.Contains(item))
                {
                    adjacents.Add(item);
                }
            }

            Dictionary<T, int> list2 = node.GetWeightedAdjList();
            foreach (T item in list2.Keys)
            {
                if (!adjacents.Contains(item))
                {
                    adjacents.Add(item);
                }
            }

            return adjacents;
        }

        //Functions for EX.4C

        public void BFS(T startID, ref List<T> visited)
        {
            throw new NotImplementedException();
        }

        public void DFS(T startID, ref List<T> visited)
        {
            throw new NotImplementedException();
        }

        public void SafestRoute(T startID, ref List<T> visited)
        {
            throw new NotImplementedException();
        }


        //Free space, use as needed




    }//End of class
}
