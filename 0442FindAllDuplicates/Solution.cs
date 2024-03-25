public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        HashSet<int> seenNums = new HashSet<int>();
        List<int> duplicates = new List<int>();

        foreach (int num in nums)
        {
            if (seenNums.Contains(num))
            {
                duplicates.Add(num);
            }
            else
            {
                seenNums.Add(num);
            }
        }
        return duplicates;
    }
}