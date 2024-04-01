public class Driver
{
    public static void Main(string[] args)
    {
        CheckContains();
        CheckContainsBST();
    }

    private static void CheckContains()
    {
        Console.WriteLine("Check Contains()");
        int?[] nums = { 5, 1, 4, null, null, 3, 6 };
        TreeNode t = TreeNode.NewTreeNode(nums);
        TreeNode.Print(t);
        Console.WriteLine("0: " + TreeNode.Contains(t, 0));
        Console.WriteLine("6: " + TreeNode.Contains(t, 6));
    }

    private static void CheckContainsBST()
    {
        Console.WriteLine();
        Console.WriteLine("Checks ContainsBST()");
        int?[] nums = { 5, 4, 8, 1, null, 7, 9, 0 };
        TreeNode t = TreeNode.NewTreeNode(nums);
        TreeNode.Print(t);
        Console.WriteLine("99: " + TreeNode.ContainsBST(t, 99));

        foreach (var num in nums)
        {
            if (num is not null)
            {
                Console.WriteLine(num + ": " + TreeNode.ContainsBST(t, num.Value));
            }
        }
    }
}