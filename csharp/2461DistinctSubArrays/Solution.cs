using System.Collections.Generic;

public class Solution
{
    public long MaximumSubarraySum(int[] nums, int k)
    {
        //Sliding Window
        //window is a static length of index + k

        //No valid subarrays exist
        if (k > nums.Length)
        {
            return 0;
        }
        long maxSum = 0;
        int left = 0;
        int right = k - 1;
        Window window = new Window(nums, left, right);

        while (window.HasNext())
        {
            if (window.IsValid() && window.GetSum() > maxSum)
            {
                maxSum = window.GetSum();
            }
            window.Next();
        }
        if (window.IsValid() && window.GetSum() > maxSum)
        {
            maxSum = window.GetSum();
        }

        return maxSum;

    }
}