public class Solution
{
    public int LengthOfLastWord(string s)
    {
        if (s == null)
        {
            return 0;
        }

	int end = s.Length - 1;
	while (end >= 0 && s[end] == ' ') {
		end--;
	}
	int start = end-1;
	while (start >= 0 && s[start] != ' ')
	{
		start--;
	}
	return end - start;
    }
}
