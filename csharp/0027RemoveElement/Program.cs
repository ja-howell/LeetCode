using System;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums1 = { 3, 2, 2, 3 };
        int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };

        int val1 = 3;
        int val2 = 2;

        // int expected1 = 2;
        // int expected2 = 5;

        int actual1 = solution.RemoveElement(nums1, val1);
        int actual2 = solution.RemoveElement(nums2, val2);

        Console.WriteLine(actual1);
        printArray(nums1);
        Console.WriteLine(actual2);
        printArray(nums2);
    }

    public static void printArray(int[] nums)
    {
        Console.Write("[");
        foreach (int num in nums)
        {
            Console.Write(" " + num);
        }
        Console.WriteLine(" ]");
    }
}