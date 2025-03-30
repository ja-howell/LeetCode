public class Solution
{
    public int MinimumBoxes(int[] apple, int[] capacity)
    {
        int totalApples = 0;
        for (int i = 0; i < apple.Length; i++)
        {
            totalApples = totalApples + apple[i];
        }

        for (int i = 1; i < capacity.Length; i++)
        {
            int j;
            int temp = capacity[i];

            for (j = i - 1; j >= 0 && capacity[j] < temp; j--)
            {
                if (temp > capacity[j])
                {
                    capacity[j + 1] = capacity[j];
                }
            }
            capacity[j + 1] = temp;
        }

        int numBoxes = 0;
        int index = 0;
        while (totalApples > 0 && index < capacity.Length)
        {
            numBoxes++;
            totalApples = totalApples - capacity[index];
            index++;
        }
        return numBoxes;
    }
}