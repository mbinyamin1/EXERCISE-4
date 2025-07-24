using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    internal class Program
    {
        private static Graph<string> graph = new Graph<string>();

        static void Main(string[] args)
        {

            //Create a Menu driven interface here so a user can interact with your implementations

            //I.e. while(true){
            // print to user - "Select an option"
            // "1. Add Loot Node"
            // "2. Add new edge... ect
            //}

            while (true)
            {
                Console.WriteLine("\n--- GRAPH ---");
                Console.WriteLine("\n1. Add A Loot Node");
                Console.WriteLine("2. Add An Edge Between Nodes");
                Console.WriteLine("3. Total Nodes");
                Console.WriteLine("4. Total Edges");
                Console.WriteLine("0. Exit");

                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddNode();
                }
                else if (choice == "2")
                {
                    AddEdge();
                }
                else if (choice == "3")
                {
                    Console.WriteLine($"\nTotal Nodes in Graph: {graph.NumNodes()}");
                }
                else if (choice == "4")
                {
                    Console.WriteLine($"\nTotal Edges in Graph: {graph.NumEdges()}");
                }
                else if (choice == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
        static void AddNode()
        {
            Console.Write("\nEnter Name Of The Looted Item: ");
            string itemName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(itemName))
            {
                graph.AddNode(itemName);
                Console.WriteLine($"Item Node '{itemName}' Added.");
            }
            else
            {
                Console.WriteLine("Name Cannot Be Empty.");
            }
        }

        static void AddEdge()
        {
            if (graph.NumNodes() < 2)
            {
                Console.WriteLine("\nNot Enough Nodes To Create An Edge.");
                return;
            }

            Console.Write("\nEnter The Name Of The Starting Node: ");
            string from = Console.ReadLine();

            Console.Write("Enter The Name Of The Ending Node: ");
            string to = Console.ReadLine();

            var fromNode = graph.GetNodeByID(from);
            var toNode = graph.GetNodeByID(to);

            if (fromNode == null || toNode == null)
            {
                Console.WriteLine("One Or Both Node/s Do Not Exist.");
                return;
            }

            graph.AddEdge(from, to);
            Console.WriteLine($"Edge Created From '{from}' To '{to}'.");
        }

    }
}
