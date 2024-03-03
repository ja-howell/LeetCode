using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage:

        int[] test1 = {5, 4, 2, 1, 3, 13, 8, 0, 109, 2, 1};
        int[] result = InsertionSort.insertSortFTB(test1);
        for(int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}