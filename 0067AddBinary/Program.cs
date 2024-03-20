using System;

class Program
{
    static void Main(string[] args)
    {
        string a = "1010";
        string b = "1011";
        Solution solution = new Solution();
        string result = solution.AddBinary(a,b);
        Console.WriteLine(result);
    }
}