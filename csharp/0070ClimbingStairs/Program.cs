using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 2; // 2
        int num2 = 35; // 3

        Solution solution = new Solution();
        Console.WriteLine(solution.ClimbStairs(num));
        Console.WriteLine(solution.ClimbStairs(num2));
    }
}