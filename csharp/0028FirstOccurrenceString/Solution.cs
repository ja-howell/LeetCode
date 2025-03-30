public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack == "" || haystack is null || needle == "" || needle is null || needle.Length > haystack.Length)
        {
            return -1;
        }

        for (int i = 0; i < haystack.Length; i++)
        {
            if (MatchesAtIndex(i, haystack, needle))
            {
                return i;
            }
        }
        return -1;
    }

    private bool MatchesAtIndex(int index, string haystack, string needle)
    {
        if (haystack.Length - index < needle.Length)
        {
            return false;
        }
        int needlePosition = 0;
        for (int i = index; i < haystack.Length; i++)
        {
            if (haystack[i] != needle[needlePosition])
            {
                return false;
            }
            needlePosition++;
        }
        return true;
    }
}