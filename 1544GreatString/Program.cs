using System;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = 
        {
            "leEeetcode",
            "abBAcC",
            "s",
            "RLlr"
        };
        Solution solution = new Solution();
        foreach(var s in strings)
        {
            Console.WriteLine("\"" + solution.MakeGood(s) + "\"");
        }

    }
}