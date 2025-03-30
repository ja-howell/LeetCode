using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nums =
        {
            "23",
            "",
            "4",
            "234"
        };

        Solution solution = new Solution();
        
        foreach (var num in nums)
        {
            IList<string> result = solution.LetterCombinations(num);
            Console.Write("[ ");
            foreach (var r in result)
            {
                Console.Write($"{r} ");
            }
            Console.WriteLine("]");
        }


    }
}