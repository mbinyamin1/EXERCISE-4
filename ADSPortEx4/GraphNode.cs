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
        public GraphNode(T id)
        {
            throw new NotImplementedException();
        }

        //Functions for EX.4A

        public T ID
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddEdge(GraphNode<T> to)
        {
            throw new NotImplementedException();
        }

        public LinkedList<T> GetAdjList()
        {
            throw new NotImplementedException();
        }

        //Functions for EX.4B

        public void AddEdgeWithWeight(GraphNode<T> to, int weight)
        {
            throw new NotImplementedException();
        }



    }// End of class
}
