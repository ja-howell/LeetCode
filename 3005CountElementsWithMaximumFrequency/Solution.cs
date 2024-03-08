using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int MaxFrequencyElements(int[]? nums)
    {
        if (nums is null)
        {
            return 0;
        }
        int maxFrequency = 1;
        Dictionary<int, int> frequencyTracker = new Dictionary<int, int>();

        //finds the max frequency
        for (int i = 0; i < nums.Length; i++)
        {
            if (frequencyTracker.ContainsKey(nums[i]))
            {
                maxFrequency = IncrementSeenVal(maxFrequency, nums[i], ref frequencyTracker);
            }
            else
            {
                AddToDictionary(nums[i], ref frequencyTracker);
            }
        }
        //calculates the number of elements with the maxFrequency
        return CalculateMaxFrequencyElements(maxFrequency, frequencyTracker);


    }

    private void AddToDictionary(int num, ref Dictionary<int, int> frequencyTracker)
    {
        //if the num is not in the dictionary add it and set seen val to 1
        frequencyTracker.Add(num, 1);
    }

    private int IncrementSeenVal(int maxFrequency, int num, ref Dictionary<int, int> frequencyTracker)
    {
        //if the num is already in the dictionary, increment the seen val
        frequencyTracker[num]++;
        //if the seen val is greater than maxFrequency replace it
        if (frequencyTracker[num] > maxFrequency)
        {
            maxFrequency = frequencyTracker[num];
        }

        return maxFrequency;
    }

    private int CalculateMaxFrequencyElements(int maxFrequency, Dictionary<int, int> frequencyTracker)
    {
        int numFrequency = 0;
        foreach (var kvp in frequencyTracker)
        {
            if (kvp.Value == maxFrequency)
            {
                numFrequency = numFrequency + kvp.Value;
            }
        }
        return numFrequency;
    }

}