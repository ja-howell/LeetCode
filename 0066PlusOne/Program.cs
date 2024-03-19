using System;

class Program
{
    static void Main(string[] args)
    {
        int[] input = { 9, 9, 7 };
        Solution solution = new Solution();
        for (int i = 0; i < 4; i++)
        {
            input = solution.PlusOne(input);
            foreach (int digit in input)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }

    }
}