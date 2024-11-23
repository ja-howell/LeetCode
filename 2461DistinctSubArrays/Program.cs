using System;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = new[] {1,5,4,2,9,9,9,7,8};
        int k = 3;
        long result = solution.MaximumSubarraySum(nums, k);
        Console.WriteLine(result);

    }
}