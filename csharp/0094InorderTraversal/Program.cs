using System;

class Program
{
    static void Main(string[] args)
    {
        Solution.TreeNode t = new Solution.TreeNode(
            1,
            null, // left
            new Solution.TreeNode(
                2,
                new Solution.TreeNode( // left
                    3,
                    new Solution.TreeNode(5, null, null), // left
                    new Solution.TreeNode(6, null, null) // right
                ),
                new Solution.TreeNode( // right
                    4,
                    new Solution.TreeNode(7, null, null), // left
                    new Solution.TreeNode(8, null, null)  // right
                )
            )
        );

        Solution solution = new Solution();
        IList<int> result = solution.InorderTraversal(t);
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }
    }
}
