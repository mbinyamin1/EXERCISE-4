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
            throw new NotImplementedException();
        }

        public double AverageWeight()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllAdjacencies(T id)
        {
            throw new NotImplementedException();
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
