using System;
using System.Collections.Generic;

namespace DSALab_11
{
    /*class HeapSort
    {
        public static void Sort(int[] array)
        {
            int heapSize = array.Length;

            // Build the heap
            for (int i = heapSize / 2 - 1; i >= 0; i--)
            {
                Heapify(array, heapSize, i);
            }

            // Extract elements from the heap one by one
            for (int i = heapSize - 1; i >= 0; i--)
            {
                // Move the current root (maximum value) to the end of the array
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // Call Heapify on the reduced heap
                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int heapSize, int index)
        {
            int largest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            // Find the largest value among the root, left, and right nodes
            if (left < heapSize && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < heapSize && array[right] > array[largest])
            {
                largest = right;
            }

            // If the largest value is not the root, swap the root with the largest value and
            // call Heapify on the affected sub-heap
            if (largest != index)
            {
                int temp = array[index];
                array[index] = array[largest];
                array[largest] = temp;

                Heapify(array, heapSize, largest);
            }
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

        public List<int> GetValues()
        {
            // Flatten the adjacency list into a single list of values
            List<int> values = adjacencyList.Values.SelectMany(x => x).ToList();

            // Sort the values using heap sort
            HeapSort.Sort(values);

            return values;
        }
    }

    class HeapSort
    {
        public static void Sort(List<int> values)
        {
            int heapSize = values.Count;

            // Build the heap
            for (int i = heapSize / 2 - 1; i >= 0; i--)
            {
                Heapify(values, heapSize, i);
            }

            // Extract elements from the heap one by one
            for (int i = heapSize - 1; i >= 0; i--)
            {
                // Move the current root (maximum value) to the end of the list
                int temp = values[0];
                values[0] = values[i];
                values[i] = temp;

                // Call Heapify on the reduced heap
                Heapify(values, i, 0);
            }
        }

        private static void Heapify(List<int> values, int heapSize, int index)
        {
            int largest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            // Find the largest value among the root, left, and right nodes
            if (left < heapSize && values[left] > values[largest])
            {
                largest = left;
            }
            if (right < heapSize && values[right] > values[largest])
            {
                largest = right;
            }

            // If the largest value is not the root, swap the root with the largest value and
            // call Heapify on the affected sub-heap
            if (largest != index)
            {
                int temp = values[index];
                values[index] = values[largest];
                values[largest] = temp;

                Heapify(values, heapSize, largest);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = { 3, 5, 1, 2, 4 };

            HeapSort.Sort(array);

            Console.WriteLine(string.Join(", ", array)); // 1, 2, 3, 4, 5*/

            Graph graph = new Graph();

            // Add some vertices and edges to the graph
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);

            // Get the values of the graph and sort them
            List<int> values = graph.GetValues();

            Console.WriteLine(string.Join(", ", values)); // 0, 1, 2, 3, 4

            Console.ReadLine();
        }
    }
}
