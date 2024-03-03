public class InsertionSort 
{
    public static int[] insertSortFTB(int[] nums)
    {
        if (nums == null || nums.Length <= 1)
        {
            return nums;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            int j;
            int temp = nums[i];

            for (j = i - 1; j >= 0 && nums[j] > temp; j--)
            {
                if (temp < nums[j])
                {
                    nums[j+1] = nums[j];
                }
            }
            nums[j+1] = temp;
        }
        return nums;
    }
}