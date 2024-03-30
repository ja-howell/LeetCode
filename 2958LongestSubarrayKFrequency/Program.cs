using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 3, 1, 2, 3, 1, 2 };
        int k1 = 2;
        int[] nums2 = { 1, 2, 1, 2, 1, 2, 1, 2 };
        int k2 = 1;
        Solution solution = new Solution();
        int result1 = solution.MaxSubarrayLength(nums1, k1);
        int result2 = solution.MaxSubarrayLength(nums2, k2);
        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}