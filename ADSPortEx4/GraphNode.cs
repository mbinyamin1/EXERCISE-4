using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    //Graph node implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 9A
    // and lab sheet 'Lab 9: Graphs Implementation' to aid with base implementation...

    //Then see materials for week 10 when moving onto 4B

    // - Adam.M 

    class GraphNode<T>
    {
        private T id;
        private LinkedList<T> adjList;
        private Dictionary<T, int> weightedAdjList = new Dictionary<T, int>();

        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
        }

        //Functions for EX.4A

        public T ID
        {
            get { return id; }
            set { id = value; }
        }

        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast(to.ID);
        }

        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }

        //Functions for EX.4B

        public void AddEdgeWithWeight(GraphNode<T> to, int weight)
        {
            weightedAdjList[to.ID] = weight;
        }

        public Dictionary<T, int> GetWeightedAdjList()
        {
            return weightedAdjList;
        }

    }// End of class
}
