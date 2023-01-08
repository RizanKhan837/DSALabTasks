using System;
using System.Collections.Generic;

namespace GraphTraversal
{
    class Graph
    {
        private Dictionary<string, List<string>> adjacencyList;
        public Graph()
        {
            adjacencyList = new Dictionary<string, List<string>>();
        }

        public void AddNode(string node)
        {
            adjacencyList[node] = new List<string>();
        }

        public void AddEdge(string source, string destination)
        {
            adjacencyList[source].Add(destination);
        }

        public bool DFS(string source, string destination)
        {
            return DFS(source, destination, new HashSet<string>());
        }

        private bool DFS(string source, string destination, HashSet<string> visited)
        {
            if (source == destination)
            {
                return true;
            }

            visited.Add(source);

            foreach (string neighbor in adjacencyList[source])
            {
                if (!visited.Contains(neighbor) && DFS(neighbor, destination, visited))
                {
                    return true;
                }
            }

            return false;
        }

        public string GetParent(string node)
        {
            foreach (string parent in adjacencyList.Keys)
            {
                if (DFS(parent, node))
                {
                    return parent;
                }
            }

            return null;
        }
        public string GetChild(string node)
        {
            foreach (string child in adjacencyList[node])
            {
                return child;
            }

            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            // Add the nodes to the graph
            graph.AddNode("Google");
            graph.AddNode("Gmail");
            graph.AddNode("Photos");
            graph.AddNode("Drive");
            graph.AddNode("Microsoft");
            graph.AddNode("Outlook");

            // Add the edges to the graph
            graph.AddEdge("Google", "Gmail");
            graph.AddEdge("Google", "Photos");
            graph.AddEdge("Google", "Drive");
            graph.AddEdge("Google", "Microsoft");
            graph.AddEdge("Microsoft", "Outlook");

            // Find the parent and child of Outlook
            string node = "Microsoft";
            string parent = graph.GetParent(node);
            string child = graph.GetChild(node);

            if (parent != null) {
                Console.WriteLine($"{node} has a parent: {parent}.");
            }
            else {
                Console.WriteLine($"{node} has no parent.");
            }

            if (child != null) {
                Console.WriteLine($"{node} has a child: {child}.");
            }
            else {
                Console.WriteLine($"{node} has no child.");
            }

            Console.ReadLine();
        }
    }
}
