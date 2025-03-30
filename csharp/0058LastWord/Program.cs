using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputs = {
            "Hello World",
            "   fly me   to   the moon  ",
            "luffy is still joyboy"
        };

        Solution solution = new Solution();
        foreach (string input in inputs)
        {
            Console.Write(input + ": ");
            int result = solution.LengthOfLastWord(input);
            Console.WriteLine(result);
        }
    }
}