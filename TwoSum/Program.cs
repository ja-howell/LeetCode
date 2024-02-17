using System;

class Program {
    static void Main(string[] args) {
        // Example usage:
        int[] nums = { 2, 4, 11, 15, 7, 17 };
        int target = 26;

        Solution solution = new Solution();
        int[] indices = solution.TwoSum(nums, target);

        if (indices != null) {
            Console.WriteLine("Indices: [" + indices[0] + ", " + indices[1] + "]");
        } else {
            Console.WriteLine("No two sum solution found.");
        }
    }
}

