public class Solution
{
    public string AddBinary(string a, string b)
    {
        while (a.Length < b.Length)
        {
            a = "0" + a;
        }
        while (b.Length < a.Length)
        {
            b = "0" + b;
        }

        string answer = "";
        bool carry = false;

        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] != b[i])
            {
                if (carry)
                {
                    answer = "0" + answer;
                }
                else
                {
                    answer = "1" + answer;
                }
            }
            else if (a[i] == '1')
            {
                if (carry)
                {
                    answer = "1" + answer;
                }
                else
                {
                    answer = "0" + answer;
                    carry = true;
                }
            }
            else
            {
                if (carry)
                {
                    answer = "1" + answer;
                    carry = false;
                }
                else
                {
                    answer = "0" + answer;
                }
            }
        }
        if (carry)
        {
            answer = "1" + answer;
        }
        return answer;
    }
}