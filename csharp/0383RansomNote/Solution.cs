public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> letterMap = new Dictionary<char, int>();
        foreach (var let in magazine)
        {
            if (!letterMap.ContainsKey(let)) 
            {
                letterMap.Add(let,1);
            }
            else
            {
                letterMap[let]++;
            }
        }
        foreach (var let in ransomNote)
        {
            if (letterMap.ContainsKey(let))
            {
                letterMap[let]--;
                if (letterMap[let] < 0)
                {
                    return false;
                }
            } else
            {
                return false;
            }

        }
        return true;
    }
}