public class TreeNode
{
    public int? val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int? val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode? NewTreeNode(int?[] nums, int i = 0)
    {
        if (i >= nums.Length || nums[i] == null)
        {
            return null;
        }
        TreeNode? root = new TreeNode(nums[i]);
        root.left = NewTreeNode(nums, Left(i));
        root.right = NewTreeNode(nums, Right(i));
        return root;
    }

    private static int Left(int i)
    {
        return 2 * i + 1;
    }

    private static int Right(int i)
    {
        return 2 * i + 2;
    }

    // 5
    // -- 1
    // -- -- null
    // -- -- null
    // -- 4
    // -- -- 3
    // -- -- -- null
    // -- -- -- null
    // -- -- 6
    // -- -- -- null
    // -- -- -- null
    public static void Print(TreeNode root, int depth = 0)
    {
        for (int i = 0; i < depth; i++)
        {
            Console.Write("-- ");
        }
        if (root == null)
        {
            Console.WriteLine("null");
            return;
        }
        Console.WriteLine(root.val);
        Print(root.left, depth + 1);
        Print(root.right, depth + 1);
    }

    public static bool Contains(TreeNode root, int key)
    {
        if (root is null)
        {
            return false;
        }
        if (root.val == key)
        {
            return true;
        }
        return (Contains(root.left, key) || Contains(root.right, key));
    }
}
