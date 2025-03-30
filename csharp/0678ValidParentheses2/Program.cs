using System;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = 
        {
            "()",
            "(*)",
            "(*))",
            "))",
            "(((()",
            "((((()(()()()*()(((((*)()*(**(())))))(())()())(((())())())))))))(((((())*)))()))(()((*()*(*)))(*)()"
        };

        Solution solution = new Solution();
        foreach (var s in strings)
        {
            Console.WriteLine($"{s} {solution.CheckValidString(s)}");
        }

    }
}