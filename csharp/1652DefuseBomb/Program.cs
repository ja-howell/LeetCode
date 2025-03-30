using System;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] code = new[] {2,4,9,3};
        int k = -2;

        int [] decoded = solution.Decrypt(code, k);
        foreach (int num in decoded)
        {
            Console.WriteLine(num);
        }

    }
}