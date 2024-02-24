using System;
using System.Text;
public class Solution{
    public bool IsPalindrome(string s) {
        s = CleanString(s);
        return ValidPalindrome(s);
    }

    public string CleanString(string s) {
        StringBuilder stringBuilder = new StringBuilder();
        string cleaned;
        foreach (char letter in s) {
            if (char.IsLetterOrDigit(letter)) {
                stringBuilder.Append(letter);
            }
        }
        cleaned = stringBuilder.ToString();
        return cleaned.ToLower();
    }
    // This works, but recursion is too slow for LeetCode
    // public bool ValidPalindrome(string s) {
    //     if (s.Length <= 1) {
    //         return true;
    //     }
    //     if (s[0] != s[s.Length - 1]) {
    //         return false;
    //     }
    //     s = s.Substring(1, (s.Length - 2));
    //     return ValidPalindrome(s);
    // }
    public bool ValidPalindrome(string s) {
        for (int i = 0; i < s.Length / 2; i++) {
            if (s[i] != s[s.Length - i - 1]) {
                return false;
            }
        }
        return true;
    }
}