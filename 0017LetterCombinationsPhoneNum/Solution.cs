public class Solution
{
    private Dictionary<char, string> keyMap = new Dictionary<char, string>
    {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}

    };
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> result = new List<string>();

        result = GetLetterCombinations(digits);
        return result;
    }

    private List<string> GetLetterCombinations(string digits)
    {
        List<string> result = new List<string>();

        if (digits == "")
        {
            return result;
        }
        if (digits.Length == 1)
        {
            foreach (var c in keyMap[digits[0]])
            {
                result.Add(c.ToString());
            }
            return result;
        }
        List<string> children = GetLetterCombinations(digits.Substring(1, digits.Length - 1));
        
        foreach (var child in children)
        {
            foreach (var c in keyMap[digits[0]])
            {
                result.Add(c.ToString() + child);
            }
        }
        return result;
    }
}