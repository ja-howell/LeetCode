using System;

class Program {
    static void Main(string[] args) {
        // Example usage:
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        Solution solution = new Solution();
        int[] indices = solution.TwoSum(nums, target);

        if (indices != null) {
            Console.WriteLine("Indices: [" + indices[0] + ", " + indices[1] + "]");
        } else {
            Console.WriteLine("No two sum solution found.");
        }
    }
}

