public class Solution
{
    public int MaxDepth(string s)
    {
        const char left = '(';
        const char right = ')';
        Stack<char> numLefts = new Stack<char>(); 
        int maxDepth = 0;
        int tempDepth = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] == left)
            {
                numLefts.Push(s[i]);
            }
            else if (s[i] == right)
            {
                tempDepth = numLefts.Count;
                maxDepth = Math.Max(tempDepth, maxDepth);
                tempDepth = 0;
                numLefts.Pop();
            }
        }
        return maxDepth;
    }
}