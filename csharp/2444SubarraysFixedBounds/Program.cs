using System;

class Program
{
    static void Main(string[] args)
    {
        // int[] nums = { 1, 3, 5, 2, 7, 5 }; //2
        int[] nums = { 1, 1, 1, 1 }; //10
        int min = 1;
        // int max = 5;
        int max = 1;
        Solution solution = new Solution();
        long result = solution.CountSubarrays(nums, min, max);
        Console.WriteLine(result);

    }
}