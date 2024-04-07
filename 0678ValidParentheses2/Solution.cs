public class Solution
{
    public bool CheckValidString(string s)
    {
        Stack<char> chars = new Stack<char>();
        char wild = '*';
        char left = '(';
        char right = ')';
        bool result = true;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == wild)
            {
                chars.Push(wild);
            }
            if (s[i] == left)
            {
                chars.Push(left);
            }
            if (s[i] == right)
            {
                result = IsRightValid(chars, left, right, wild);
            }
            if (result == false)
            {
                return result;
            }
        }
        //If we still have chars check to make sure that there are no lefts to the right of wilds and enough wilds for lefts
        if (!IsEmpty(chars))
        {
            result = ValidateRemainingStack(chars, left, wild);
        }
        return result;
    }

    private static bool IsRightValid(Stack<char> chars, char left, char right, char wild)
    {
        if (IsEmpty(chars))
        {
            return false;
        }
        else if (!IsEmpty(chars) && chars.Peek() == left)
        {
            chars.Pop();
            return true;
        }
        else if (!IsEmpty(chars) && chars.Peek() == wild)
        {
            CheckForLeft(chars, left, wild);
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool IsEmpty(Stack<char> stack)
    {
        if (stack.Count == 0)
        {
            return true;
        }
        return false;
    }

    private static void CheckForLeft(Stack<char> stack, char left, char wild)
    {
        int counter = 0;
        bool foundLeft = false;
        char temp;
        while (!IsEmpty(stack) && foundLeft == false)
        {
            temp = stack.Pop();
            if (temp == wild)
            {
                counter++;
            }
            else if (temp == left)
            {
                foundLeft = true;
            }
        }
        if (foundLeft)
        {
            while (counter > 0)
            {
                stack.Push(wild);
                counter--;
            }
        }
        else
        {
            //Use a wild
            counter--;
            //put any others back
            while (counter > 0)
            {
                stack.Push(wild);
                counter--;
            }
        }
    }
    private static bool ValidateRemainingStack(Stack<char> stack, char left, char wild)
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