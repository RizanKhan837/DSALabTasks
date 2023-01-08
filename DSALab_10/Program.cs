using System;
using System.Collections.Generic;

namespace GraphTraversal
{
    /*class Graph
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
    }*/

    /*class Graph
    {
        private int[,] adjacencyMatrix;
        private int numVertices;

        public Graph(int numVertices)
        {
            this.numVertices = numVertices;
            adjacencyMatrix = new int[numVertices, numVertices];
        }

        public void AddEdge(int source, int destination)
        {
            adjacencyMatrix[source, destination] = 1;
            adjacencyMatrix[destination, source] = 1;
        }

        public void RemoveEdge(int source, int destination)
        {
            adjacencyMatrix[source, destination] = 0;
            adjacencyMatrix[destination, source] = 0;
        }

        public bool IsAdjacent(int source, int destination)
        {
            return adjacencyMatrix[source, destination] == 1;
        }
    }*/

    /*class Graph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int vertex)
        {
            adjacencyList[vertex] = new List<int>();
        }

        public void AddEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
            adjacencyList[destination].Add(source);
        }

        public void RemoveEdge(int source, int destination)
        {
            adjacencyList[source].Remove(destination);
            adjacencyList[destination].Remove(source);
        }

        public bool IsAdjacent(int source, int destination)
        {
            return adjacencyList[source].Contains(destination);
        }
    }*/

    class Graph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int vertex)
        {
            adjacencyList[vertex] = new List<int>();
        }

        public void AddEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
            adjacencyList[destination].Add(source);
        }

        public void BFS(int start)
        {
            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");

                foreach (int neighbor in adjacencyList[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Graph graph = new Graph();
            // Add some vertices to the graph
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);

            // Add some edges to the graph
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);

            // Perform BFS starting from vertex 0
            graph.BFS(0); // 0 1 2 3
            Console.ReadLine();

            /*Graph graph = new Graph();

            // Add some vertices to the graph
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);

            // Add some edges to the graph
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);

            // Check if some pairs of vertices are adjacent
            Console.WriteLine(graph.IsAdjacent(0, 1)); // True
            Console.WriteLine(graph.IsAdjacent(0, 3)); // False
            Console.WriteLine(graph.IsAdjacent(1, 4)); // False
            Console.ReadLine();*/

            /*Graph graph = new Graph(5);

            // Add some edges to the graph
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);

            // Check if some pairs of vertices are adjacent
            Console.WriteLine(graph.IsAdjacent(0, 1)); // True
            Console.WriteLine(graph.IsAdjacent(0, 3)); // False
            Console.WriteLine(graph.IsAdjacent(1, 4)); // False
            Console.ReadLine();*/


            /*Graph graph = new Graph();

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
            }*/

        }
    }
}
