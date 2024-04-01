public class Driver
{
    public static void Main(string[] args)
    {
        int?[] nums = {5, 1, 4, null, null, 3, 6};
        TreeNode t = TreeNode.NewTreeNode(nums);
        TreeNode.Print(t);
        Console.WriteLine("0: " + TreeNode.Contains(t, 0));
        Console.WriteLine("6: " + TreeNode.Contains(t, 6));
    }
}