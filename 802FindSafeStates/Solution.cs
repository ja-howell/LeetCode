public class Solution
{
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        HashSet<int>[] graphSet = ToGraphSet(graph);
        List<int> safe = new List<int>();
        bool changed = true;

        while (changed)
        {
            changed = false;
            for (int i = 0; i < graphSet.Length; i++)
            {
                if (!safe.Contains(i) && graphSet[i].Count == 0)
                {
                    safe.Add(i);
                    PruneNode(ref graphSet, i);
                    changed = true;
                }
            }

        }
        safe.Sort();
        return safe;
    }

    private static HashSet<int>[] ToGraphSet(int[][] graph)
    {
        HashSet<int>[] graphSet = new HashSet<int>[graph.Length];
        for (int i = 0; i < graph.Length; i++)
        {
            graphSet[i] = new HashSet<int>();
            for (int j = 0; j < graph[i].Length; j++)
            {
                graphSet[i].Add(graph[i][j]);
            }
        }
        return graphSet;
    }

    private static void PruneNode(ref HashSet<int>[] graphSet, int node)
    {
        for (int i = 0; i < graphSet.Length; i++)
        {
            graphSet[i].Remove(node);
        }
    }

    // private static void PrintGraphSet(HashSet<int>[] graphSet)
    // {
    //     for (int i = 0; i < graphSet.Length; i++)
    //     {
    //         Console.Write($"{i}: ");
    //         foreach (int n in graphSet[i])
    //         {
    //             Console.Write($"{n} ");
    //         }
    //         Console.WriteLine();
    //     }
    // }
}
