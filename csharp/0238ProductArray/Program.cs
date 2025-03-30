using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { -1, 1, 0, -3, 3};

        Solution solution = new Solution();
        int[] result = solution.ProductExceptSelf(nums);
        
        Array.ForEach(result, Console.WriteLine);

    }
}