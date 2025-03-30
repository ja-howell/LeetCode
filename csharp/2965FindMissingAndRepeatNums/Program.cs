using System;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[][] grid = {
            new int[] {9,1,7},
            new int[] {8,9,2},
            new int[] {3,4,6}
        };

        int[] result = solution.FindMissingAndRepeatedValues(grid);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

    }
}