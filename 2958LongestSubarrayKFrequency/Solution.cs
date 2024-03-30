public class Solution
{
    public int MaxSubarrayLength(int[] nums, int k)
    {
        int l = 0;
        int r = 0;
        int max = 0;
        Dictionary<int, int> numsCounter = new Dictionary<int, int>();
        while (r < nums.Length)
        {
            int num = nums[r];
            if (!numsCounter.ContainsKey(num))
            {
                numsCounter[num] = 1;
            }
            else
            {
                numsCounter[num]++;
            }
            if (numsCounter[num] > k)
            {
                int candidate = r - l;
                if (candidate > max)
                {
                    max = candidate;
                }

                while (numsCounter[num] > k)
                {
                    numsCounter[nums[l]]--;
                    l++; 
                }
            }
            r++;
        }
        if (max < r - l)
        {
            return r - l;
        }
        return max;
    }
}