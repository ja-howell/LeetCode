using System;

class Program
{
    static void Main(string[] args)
    {
        // int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
        // int[] nums = { 1, 1, 2 };
        int[] nums = { 1 };

        Solution solution = new Solution();
        IList<int> result = solution.FindDuplicates(nums);
        foreach (int num in result)
        {
            Console.Write(num + ", ");
        }

    }
}