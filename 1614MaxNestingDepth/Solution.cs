public class Solution
{
    public int MaxDepth(string s)
    {
        const char left = '(';
        const char right = ')';
        int numLefts = 0;
        int maxDepth = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] == left)
            {
                numLefts++;
            }
            else if (s[i] == right)
            {
                maxDepth = Math.Max(numLefts, maxDepth);
                numLefts--;
            }
        }
        return maxDepth;
    }
}