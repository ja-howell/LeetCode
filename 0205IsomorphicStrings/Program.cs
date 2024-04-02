using System;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "egg";
        string t1 = "add"; 
        string s2 = "foo";
        string t2 = "bar";
        Solution solution = new Solution();
        Console.WriteLine(solution.IsIsomorphic(s1, t1));
        Console.WriteLine(solution.IsIsomorphic(s2, t2));

    }
}