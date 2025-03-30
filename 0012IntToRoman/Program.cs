using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1994, 58, 3};


        Solution solution = new Solution();
        foreach (int num in nums)
        {
            Console.WriteLine("Input:  " + num.ToString());
            string result = solution.IntToRoman(num);
            Console.WriteLine("Output: " + result);

        }
    }
}