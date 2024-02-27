using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage:
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        Solution solution = new Solution();
        int k = solution.RemoveDuplicates(nums);

        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(nums[i]);
        }
        Console.WriteLine("k: " + k);
    }
}