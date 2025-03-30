using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 3, 4, 2, 2};

        Solution solution = new Solution();
        Console.WriteLine(solution.FindDuplicate(nums));

    }
}