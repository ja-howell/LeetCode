using System.Text;

public class Solution
{
    public string MakeGood(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        int length = sb.Length;
        int i = 0;
        while (i < sb.Length)
        {
            sb = CheckAndRemoveAdjacents(sb, i);
            i++;
            if (length > sb.Length)
            {
                i = 0;
                length = sb.Length;
            }
        }
        return sb.ToString();
    }

    private static StringBuilder CheckAndRemoveAdjacents(StringBuilder sb, int i)
    {
        if (i < sb.Length - 1 && IsSameCharOppositeCase(sb[i], sb[i + 1]))
        {
            sb.Remove(i, 2);
        }
        return sb;
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
