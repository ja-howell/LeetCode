public class Solution
{
    public string IntToRoman(int num)
    {
        string onesRoman = ConvertDigit(FindDigit(num, 1), 'I', 'V', 'X');
        string tensRoman = ConvertDigit(FindDigit(num, 2), 'X', 'L', 'C');
        string hunsRoman = ConvertDigit(FindDigit(num, 3), 'C', 'D', 'M');
        string thosRoman = ConvertDigit(FindDigit(num, 4), 'M', ' ', ' ');
        return thosRoman + hunsRoman + tensRoman + onesRoman;
    }

    private string ConvertDigit(int digit, char start, char mid, char end)
    {
        if (digit == 0)
        {
            return "";
        }
        else if (digit < 4)
        {
            return new string(start, digit);
        }
        else if (digit == 4)
        {
            return start.ToString() + mid.ToString();
        }
        else if (digit == 5)
        {
            return mid.ToString();
        }
        else if (digit < 9)
        {
            return mid.ToString() + new string(start, (digit - 5));
        }
        else
        {
            return start.ToString() + end.ToString();
        }
    }

    private int FindDigit(int num, int pos)
    {
		// 123 % 10**2 == 23
		// 99912349234523 % 10**2 == 23
		// 23 / 10**1 = 2
		int result = num % (int)Math.Pow(10, pos);
		return result / (int)Math.Pow(10, pos - 1);
    }

}
