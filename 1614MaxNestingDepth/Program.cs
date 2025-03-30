using System;

class Program
{
    static void Main(string[] args)
    {
        string[] vps = {
            "(1+(2*3)+((8)/4))+1",
            "(1)+((2))+(((3)))"
        };
        

        Solution solution = new Solution();
        foreach (var s in vps)
        {
            int result = solution.MaxDepth(s);
            Console.WriteLine(result);
        }
    }
}