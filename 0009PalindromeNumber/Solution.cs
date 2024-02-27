using System;
using System.Collections.Generic;
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        List<int> digits = new List<int>();
        while (x != 0)
        {
            int y = x % 10;
            x = x / 10;
            digits.Add(y);
        }
        for (int i = 0; i < digits.Count / 2; i++)
        {
            if (digits[i] != digits[digits.Count - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}