public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        Dictionary<int, bool> foundNums = new Dictionary<int, bool>();
        for (int i = 1; i <= Math.Pow(grid.Length,2); i++)
        {
            foundNums[i] = false;
        }

        int[] result = new int[2];
        foreach (int[] row in grid)
        {
            foreach (int num in row)
            {
                if (foundNums[num] == true)
                {
                    result[0] = num;
                }
                foundNums[num] = true;
            }
        }

        foreach (var item in foundNums)
        {
            if (item.Value == false)
            {
                result[1] = item.Key;
            }
        }

        return result;
    }
}