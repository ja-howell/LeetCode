public class Solution
{
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        HashSet<int> safe = new HashSet<int>();
        HashSet<int> notSafe = new HashSet<int>();

        for (int i = 0; i < graph.Length; i++)
        {
            HashSet<int> visited = new HashSet<int>();
            if (!notSafe.Contains(i) || !safe.Contains(i))
            {
                if (IsSafeNode(i, graph, visited, ref notSafe, ref safe))
                {
                    safe.Add(i);
                }
                else
                {
                    notSafe.Add(i);
                }
            }
        }

        List<int> safeList = new List<int>();
        foreach (int n in safe)
        {
            safeList.Add(n);
        }
        safeList.Sort();
        return safeList;
    }

    private static bool IsSafeNode(int node, int[][] graph, HashSet<int> visited, ref HashSet<int> notSafe, ref HashSet<int> safe)
    {
        if (graph[node].Length == 0 || safe.Contains(node))
        {
            safe.Add(node);
            return true;
        }
        if (notSafe.Contains(node) || visited.Contains(node))
        {
            notSafe.Add(node);
            return false;
        }
        visited.Add(node);
        foreach (int v in graph[node])
        {
            if (!IsSafeNode(v, graph, visited, ref notSafe, ref safe))
            {
                return false;
            }
        }
        visited.Remove(node);
        safe.Add(node);
        return true;
    }
}
