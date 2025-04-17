using System;

class Program
{
    static void Main(string[] args)
    {
        string magazine = "ab";
        string note = "aa";
        Solution solution = new Solution();

        Console.Write(solution.CanConstruct(note, magazine));

    }
}