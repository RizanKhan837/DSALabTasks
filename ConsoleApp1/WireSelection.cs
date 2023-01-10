using System;
using System.Linq;

namespace ConsoleApp1
{
    class WireSelection
    {
        internal class Edge
        {
            public int Source { get; set; }
            public int Destination { get; set; }
            public int RiskFactor { get; set; }
        }

        // Helper class to represent subsets for union-find
        internal class Subset
        {
            public int Parent { get; set; }
            public int Rank { get; set; }
        }

        // Finds the set of a node using path compression
        private static int Find(Subset[] subsets, int i)
        {
            // If the current node is not the parent of the set
            if (subsets[i].Parent != i)
                subsets[i].Parent = Find(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }

        // Connect two sets using union-by-rank
        private static void Union(Subset[] subsets, int x, int y)
        {
            int xroot = Find(subsets, x);
            int yroot = Find(subsets, y);

            if (subsets[xroot].Rank < subsets[yroot].Rank)
                subsets[xroot].Parent = yroot;
            else if (subsets[xroot].Rank > subsets[yroot].Rank)
                subsets[yroot].Parent = xroot;
            else
            {
                subsets[yroot].Parent = xroot;
                subsets[xroot].Rank++;
            }
        }

        public static Edge[] SelectWires(int numComputers, Edge[] edges)
        {
            Array.Sort(edges, (e1, e2) => e1.RiskFactor.CompareTo(e2.RiskFactor));

            Edge[] result = new Edge[numComputers - 1];
            int e = 0, i = 0;
            Subset[] subsets = new Subset[numComputers];
            for (int v = 0; v < numComputers; ++v)
            {
                subsets[v] = new Subset() { Parent = v, Rank = 0 };
            }

            while (e < numComputers - 1)
            {
                Edge next_edge = edges[i++];

                int x = Find(subsets, next_edge.Source);
                int y = Find(subsets, next_edge.Destination);

                if (x != y)
                {
                    result[e++] = next_edge;
                    Union(subsets, x, y);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int numComputers = 5;
            Edge[] edges = new Edge[] {
            new Edge() { Source = 0, Destination = 1, RiskFactor = 0 },
            new Edge() { Source = 0, Destination = 2, RiskFactor = 5 },
            new Edge() { Source = 0, Destination = 3, RiskFactor = 3 },
            new Edge() { Source = 0, Destination = 4, RiskFactor = 7 },
            new Edge() { Source = 1, Destination = 2, RiskFactor = 2 },
            new Edge() { Source = 1, Destination = 3, RiskFactor = 8 },
            new Edge() { Source = 3, Destination = 4, RiskFactor = 9 },
            };

            Edge[] mst = SelectWires(numComputers, edges);

            Console.WriteLine("Minimum Spanning Tree:");
            for (int i = 0; i < mst.Length; i++) {
                Console.WriteLine("{0} - {1} : {2}", mst[i].Source, mst[i].Destination, mst[i].RiskFactor);
            }
            Console.ReadLine();
        }
    }
}
