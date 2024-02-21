using System;

class Program {
    static void Main(string[] args) {
        // Example usage:
        string[] strs = {"flower", "flow", "flight"};
        string[] strs2 = {"ab", "a"};
        

        Solution solution = new Solution();
        string prefix = solution.LongestCommonPrefix(strs);
        string prefix2 = solution.LongestCommonPrefix(strs2);

        Console.WriteLine(prefix);
        Console.WriteLine(prefix2);
    }
}
