public class Solution
{
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        long totalHappiness = 0;
        Array.Sort(happiness);
        Array.Reverse(happiness);

        for (int i = 0; i < k; i++)
        {
            happiness[i] = happiness[i] - i;
            if (happiness[i] <= 0)
            {
                return totalHappiness;
            }
            else
            {
                totalHappiness = totalHappiness + happiness[i];
            }
        }
        return totalHappiness;
    }
}