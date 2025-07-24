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
                Console.WriteLine("\n--- MY LOOTED BANK ---");
                Console.WriteLine("\n1. Add A Loot Node");
                Console.WriteLine("2. Add An Edge With Weight");
                Console.WriteLine("3. Total Nodes");
                Console.WriteLine("4. Total Edges");
                Console.WriteLine("0. Exit");

                Console.Write("\nEnter Your Choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddNode();
                }
                else if (choice == "2")
                {
                    AddEdgeWithWeight();
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
                    Console.WriteLine("\nInvalid Choice.");
                }
            }
        }
        static void AddNode()
        {
            Console.Write("\nEnter Name Of The Looted Item: ");
            string itemName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(itemName))
            {
                Console.WriteLine("\nName Cannot Be Empty.");
                return;
            }

            if (graph.GetNodeByID(itemName) != null)
            {
                Console.WriteLine($"\nItem \"{itemName}\" Already Exists.");
                return;
            }

            graph.AddNode(itemName);
            Console.WriteLine($"\nItem Node \"{itemName}\" Has Been Added Successfully.");
        }

        static void AddEdgeWithWeight()
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

            if (fromNode == null)
            {
                Console.WriteLine($"Node \"{from}\" Does Not Exist.");
                return;
            }
            if (toNode == null)
            {
                Console.WriteLine($"Node \"{to}\" Does Not Exist.");
                return;
            }

            Console.Write("Enter Weight Of The Edge (1–10): ");
            if (!int.TryParse(Console.ReadLine(), out int weight) || weight < 1 || weight > 10)
            {
                Console.WriteLine("Invalid Weight. Must Be Between 1 And 10.");
                return;
            }

            if (fromNode.GetAdjList().Contains(to))
            {
                Console.WriteLine($"Edge From \"{from}\" To \"{to}\" Already Exists.");
                return;
            }

            graph.AddWeightedEdge(from, to, weight);
            Console.WriteLine($"Edge From \"{from}\" To \"{to}\" With Weight {weight} Has Been Created Successfully.");
        }


    }
}
