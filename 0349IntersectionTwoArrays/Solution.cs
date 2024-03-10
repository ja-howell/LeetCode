public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> nums1Set = new HashSet<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            nums1Set.Add(nums1[i]);
        }
        
        HashSet<int> intersection = new HashSet<int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            if (nums1Set.Contains(nums2[i]))
            {
                intersection.Add(nums2[i]);
            }
        }

        int[] result = new int[intersection.Count];
        int index = 0;
        foreach (int i in intersection)
        {
            result[index] = i;
            index++;
        }

        return result;
    }

}