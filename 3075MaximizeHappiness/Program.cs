using System;

class Program
{
    static void Main(string[] args)
    {
        int[] happiness = { 2, 3, 4, 5 };
        int k = 1;

        Solution solution = new Solution();
        long result = solution.MaximumHappinessSum(happiness, k);
        Console.WriteLine(result);
    }
}