using System.Text;

public class Solution
{
    public string MakeGood(string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (sb.Length > 0 && IsSameCharOppositeCase(s[i], sb[sb.Length - 1])) {
                sb.Remove(sb.Length - 1, 1);
            }
            else
            {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }

    private static bool IsSameCharOppositeCase(char x, char y)
    {
        return IsSameChar(x, y) && IsOppositeCase(x, y);
    }

    private static bool IsSameChar(char x, char y)
    {
        return char.ToLower(x) == char.ToLower(y);
    }

    private static bool IsOppositeCase(char x, char y)
    {
        return (char.IsUpper(x) && char.IsLower(y)) || (char.IsLower(x) && char.IsUpper(y));
    }
}
