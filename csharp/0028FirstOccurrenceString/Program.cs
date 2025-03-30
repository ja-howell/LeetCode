using System;

class Program
{
    static void Main(string[] args)
    {
        string haystack = "leetcode";
        string needle = "leeto";

        Solution solution = new Solution();
        int result = solution.StrStr(haystack, needle);
        Console.WriteLine(result);

    }
}