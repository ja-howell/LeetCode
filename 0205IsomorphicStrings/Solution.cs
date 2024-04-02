public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> dictS = new Dictionary<char, char>();
        Dictionary<char, char> dictT = new Dictionary<char, char>();

        if (s.Length != t.Length)
        {
            return false;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (!dictS.ContainsKey(s[i]))
            {
                if (!dictT.ContainsKey(t[i]))
                {
                    dictS.Add(s[i], t[i]);
                    dictT.Add(t[i], s[i]);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (dictS[s[i]] != t[i] || dictT[t[i]] != s[i])
                {
                    return false;
                }
            }
        }
        return true;

    }
}