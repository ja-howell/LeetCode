using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] testCases = {
            new int[] { 1, 2, 2, 2, 2, 3, 3, 4, 5, 5, 5, 6 },
            new int[] { 1, 2, 3, 4, 5, 5, 5, 6 },
            new int[] { }
        };
        Solution solution = new Solution();
        foreach (int[] testCase in testCases)
        {
            ListNode? test1 = null;
            foreach (var num in testCase)
            {
                ListNode.append(ref test1, num);
            }

            ListNode? result = solution.DeleteDuplicates(test1);
            ListNode.print(ref result);
        }
    }
}