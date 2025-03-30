using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = {1, 2, 2, 1};
        int[] nums2 = {2, 2};

        Solution solution = new Solution();
        int[] result = solution.Intersection(nums1, nums2);
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }

    }
}