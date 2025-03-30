using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] graph = {
            new int[] {},
            new int[] {0,2,3,4},
            new int[] {3},
            new int[] {4},
            new int[] {},
        };
        Solution solution = new Solution();

        IList<int> result = solution.EventualSafeNodes(graph);

        foreach (int n in result) {
            Console.WriteLine(n);
        }


    }
}