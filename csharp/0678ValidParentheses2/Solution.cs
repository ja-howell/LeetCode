public class Solution
{
    const char wild = '*';
    const char left = '(';
    const char right = ')';
    public bool CheckValidString(string s)
    {
        Stack<char> chars = new Stack<char>();
        bool result = true;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == wild || s[i] == left)
            {
                chars.Push(s[i]);
            }
            else
            {
                result = IsRightValid(chars);
            }
            if (!result)
            {
                return false;
            }
        }
        //If we still have chars check to make sure that there are no lefts to the right of wilds and enough wilds for lefts
        if (!IsEmpty(chars))
        {
            result = ValidateRemainingStack(chars);
        }
        return result;
    }

    private static bool IsRightValid(Stack<char> chars)
    {
        if (IsEmpty(chars))
        {
            return false;
        }
        
        if (chars.Peek() == left)
        {
            chars.Pop();
            return true;
        }
        else if (chars.Peek() == wild)
        {
            CheckForLeft(chars);
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool IsEmpty(Stack<char> stack)
    {
        return stack.Count == 0;
    }

    private static void CheckForLeft(Stack<char> stack)
    {
        int counter = 0;
        bool foundLeft = false;
        char temp;
        while (!IsEmpty(stack) && !foundLeft)
        {
            temp = stack.Pop();
            if (temp == wild)
            {
                counter++;
            }
            else
            {
                foundLeft = true;
            }
        }
        if (!foundLeft)
        {
            counter--;
        }
        while (counter > 0)
        {
            stack.Push(wild);
            counter--;
        }
    }
    private static bool ValidateRemainingStack(Stack<char> stack)
    {
        char temp;
        int wildCount = 0;
        while (!IsEmpty(stack))
        {
            temp = stack.Pop();
            if (temp == left && wildCount == 0)
            {
                return false;
            }
            else if (temp == left && wildCount > 0)
            {
                wildCount--;
            }
            else
            {
                wildCount++;
            }
        }
        return true;
    }
}