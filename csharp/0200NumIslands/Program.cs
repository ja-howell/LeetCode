using System;

class Program
{
    static void Main(string[] args)
    {
        char[][] grid = new char[][] 
        {
            new char[] { '1', '1', '1', '1', '0' },
            new char[] { '1', '1', '0', '1', '0' },
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '0', '0', '0', '0', '0' }
        };

        Solution solution = new Solution();
        Console.WriteLine(solution.NumIslands(grid));
    }
}