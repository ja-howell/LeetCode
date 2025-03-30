using System;

class Program
{
    static void Main(string[] args)
    {
        // string s = "()";
        // string s = "()[]{}";
        // string s = "(1]";
        string s = "([]{})";
        // string s = ")))";
        // string s = "()(";
        // string s = "())";

        Solution solution = new Solution();
        bool result = solution.IsValid(s);
        Console.WriteLine(s);
        Console.WriteLine(result);
    }
}
