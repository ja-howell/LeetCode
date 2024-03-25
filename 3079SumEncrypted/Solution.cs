public class Solution
{
    public int SumOfEncryptedInt(int[] nums)
    {
        int total = 0;
        foreach (int num in nums)
        {
            total += Encrypt(num);
        }
        return total;
    }

    private int Encrypt(int num)
    {
        int pow = 1;
        int highestDigit = 0;
        while (pow <= 4)
        {
            int FoundDigit = FindDigit(num, pow);
            if (FoundDigit > highestDigit)
            {
                highestDigit = FoundDigit;
            }
            pow++;
        }
        if (num >= 1000)
        {
            return highestDigit * 1111;
        }
        else if (num >= 100)
        {
            return highestDigit * 111;
        }
        else if (num >= 10)
        {
            return highestDigit * 11;
        }
        return highestDigit;
    }

    private int FindDigit(int num, int pow)
    {
        int digit = num % (int)Math.Pow(10, pow);
        return digit / (int)Math.Pow(10, pow - 1);
    }
}