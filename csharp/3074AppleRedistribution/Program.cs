using System;

class Program
{
    static void Main(string[] args)
    {
        int[] apple = {1, 3, 2};
        int[] capacity = {4, 3, 1, 5, 2};

        Solution solution = new Solution();
        int result = solution.MinimumBoxes(apple, capacity);
        Console.WriteLine(result);
    }
}