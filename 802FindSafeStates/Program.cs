using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] graph = {
            new int[] {1,2},
            new int[] {2,3},
            new int[] {5},
            new int[] {0},
            new int[] {5},
            new int[] {},
            new int[] {}

        };
        Solution solution = new Solution();

        IList<int> result = solution.EventualSafeNodes(graph);

        foreach (int n in result) {
            Console.WriteLine(n);
        }


    }
}