public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        //null checks
        HashSet<int> duplicate = new HashSet<int>();
        foreach(var num in nums)
        {
            if (duplicate.Contains(num))
            {
                return num;
            }
            duplicate.Add(num);
        }
        //Case if not found
        return 0;
    }

}