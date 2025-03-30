public class Solution
{
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        long counter = 0;
        int l = 0;
        int r = 0;
        Dictionary<int, int> validKs = new Dictionary<int, int>();
        if (minK == maxK)
        {
            validKs.Add(minK, 0);
        }
        else{
            validKs.Add(minK, 0);
            validKs.Add(maxK, 0);
        }


        while (r < nums?.Length)
        {
            if (!InBounds(nums[r], minK, maxK))
            {
                counter += CountInWindow(nums, l, validKs, minK, maxK);
                Console.WriteLine("Not in bounds, r: " + nums[r] + " Count: " + counter);
                l = r;
            }
            if (validKs.ContainsKey(nums[r]))
            {
                validKs[nums[r]]++;
            }

            if (validKs[minK] > 0 && validKs[maxK] > 0)
            {
                counter++;
            }
            Console.WriteLine("r: " + nums[r] + " Count: " + counter);
            r++;
        }
        counter += CountInWindow(nums, l, validKs, minK, maxK);
        return counter;
    }
    
    private static bool InBounds(int num, int min, int max)
    {
        return min <= num && num <= max;
    }
    
    private static long CountInWindow(int[] nums, int i, Dictionary<int, int> validKs, int min, int max)
    {
        //increment i until one value of validKs is 0
        long counter = 0;
        while (validKs[min] != 0 && validKs[max] != 0)
        {
            if (validKs.ContainsKey(nums[i]))
            {
                validKs[nums[i]]--;
                if (validKs[nums[i]] == 0)
                {
                    return counter;
                }

            }
            counter++;
            i++;
        }
        return counter;
    }
}