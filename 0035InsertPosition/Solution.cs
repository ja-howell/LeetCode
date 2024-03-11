public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int begin = 0;
        int end = nums.Length;
        return BinarySearch(nums, target, begin, end);

    }

    private int BinarySearch(int[] nums, int target, int begin, int end)
    {
        int mid = (begin + end) / 2;
        if (mid >= nums.Length || target == nums[mid])
        {
            return mid;
        }
        if (begin == end)
        {
            if (nums[mid] < target)
            {
                return mid + 1;
            }
            return mid;    
        }
        if (target < nums[mid])
        {
            return BinarySearch(nums, target, begin, mid);
        }
        return BinarySearch(nums, target, mid + 1, end);
    }
}