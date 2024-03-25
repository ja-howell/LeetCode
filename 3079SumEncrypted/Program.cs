using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3 };
        int[] nums2 = { 10, 21, 31 };

        Solution solution = new Solution();
        Console.WriteLine(solution.SumOfEncryptedInt(nums));
        Console.WriteLine(solution.SumOfEncryptedInt(nums2));
    }
}