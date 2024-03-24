public class Solution
{
    public int ClimbStairs(int n)
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        return (ClimbStairsMemo(n, memo));
    }

    private int ClimbStairsMemo(int n, Dictionary<int, int> memo)
    {
        if (memo.ContainsKey(n))
        {
            return memo[n];
        }
        if (n == 0 || n == 1)
        {
            memo[n] = 1;
            return 1;
        }
        if (n < 0)
        {
            memo[n] = 0;
            return 0;
        }
        int result = ClimbStairsMemo(n - 1, memo) + ClimbStairsMemo(n - 2, memo);
        memo[n] = result;
        return result;
    }
}