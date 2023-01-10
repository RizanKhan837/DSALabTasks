internal class WireSelectionBase
{

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
}