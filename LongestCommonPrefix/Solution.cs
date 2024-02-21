public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) {
            return "";
        }
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++) {
            string str = strs[i];
            if (prefix.Length > str.Length) {
                prefix = prefix.Substring(0, str.Length);
            }
            for (int j = 0; j < str.Length && j < prefix.Length; j++) {
                if (str[j] != prefix[j]) {
                    prefix = prefix.Substring(0, j);
                    break;
                }
            }
        }
        return prefix;
    }
}