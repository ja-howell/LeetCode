public class TwoSumShould
{
    [Fact]
    public void TwoSum_SuccessCase()
    {
        int[] nums = { 2, 4, 11, 15, 7, 17 };
        int target = 26;

        Solution solution = new Solution();
        int[] indices = solution.TwoSum(nums, target);
        int[] expected = {2,3};
        Array.Sort(indices);

        Assert.Equal(expected, indices);
    }
}