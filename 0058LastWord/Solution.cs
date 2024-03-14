public class Solution
{
    public int LengthOfLastWord(string s)
    {
        if (s == null)
        {
            return 0;
        }
        int next = findNextStartIndex(0, s);
        int end = 0;
        int start = 0;
        while (next != -1)
        {
            start = next;
            end = findNextEndIndex(next, s);
            next = findNextStartIndex(end, s);            
        }

        return end - start;
    }

    private int findNextStartIndex(int i, string s)
    {
        while (i < s.Length)
        {
            if (s[i] != ' ')
            {
                return i;
            }
            i++;
        }
        return -1;
    }

    private int findNextEndIndex(int i, string s)
    {
        while (i < s.Length)
        {
            if (s[i] == ' ')
            {
                return i;
            }          
            i++;
        }
        return s.Length;
    }
}