using System;

class Program
{
    static void Main(string[] args)
    {
        // int[]? nums = null;
        // int[]? nums = { 1 };
        int[]? nums = { 1, 2, 2, 3, 1, 4 };

        Solution solution = new Solution();

        int result = solution.MaxFrequencyElements(nums);
        Console.WriteLine(result);

    }
}