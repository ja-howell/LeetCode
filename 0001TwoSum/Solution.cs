using System;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int lookingFor = target - nums[i];
            if (seen.ContainsKey(lookingFor)) {
                int[] indices = {i, seen[lookingFor]};
                return indices;
            }
            // Add candidate as key, index as value
            seen[nums[i]] = i;
        }
        return new int[0];
    }
}