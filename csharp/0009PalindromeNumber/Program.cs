using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage:
        int num = 12321;
        bool isPalindrome;

        Solution solution = new Solution();
        isPalindrome = solution.IsPalindrome(num);

        Console.WriteLine(isPalindrome);
    }
}
