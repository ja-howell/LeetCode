public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;

                if (i == 0)
                {
                    int[] result = new int[digits.Length + 1];
                    result[0] = 1;
                    return result;
                }
            }
            else
            {
                digits[i]++;
                return digits;
            }

        }
        return digits;
    }
}