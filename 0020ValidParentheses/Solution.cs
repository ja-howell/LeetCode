public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (IsOpener(c))
            {
                stack.Push(c);
            }
            else if (IsCloser(c))
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                if (Matches(stack.Peek(), c))
                {
                    stack.Pop();
                }
                return false;
            }
        }
        return stack.Count == 0;
    }

    private bool Matches(char opener, char closer)
    {
        return (opener == '(' && closer == ')') ||
        (opener == '[' && closer == ']') ||
        (opener == '{' && closer == '}');
    }

    private bool IsOpener(char c)
    {
        return c == '(' || c == '[' || c == '{';
    }

    private bool IsCloser(char c)
    {
        return c == ')' || c == ']' || c == '}';
    }
}
