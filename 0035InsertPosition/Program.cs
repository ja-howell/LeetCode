using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 3, 5, 6};
        int target = 7;

        Solution solution = new Solution();
        int result = solution.SearchInsert(nums, target);
        Console.WriteLine(result);
    }
}