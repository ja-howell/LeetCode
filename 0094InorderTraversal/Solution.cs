

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> list = new List<int>();
        if (root.left != null)
        {
            List<int> L = (List<int>)InorderTraversal(root.left);
            list = L;
        }
        list.Add(root.val);
        if (root.right != null)
        {
            List<int> R = (List<int>)InorderTraversal(root.right);
            list.AddRange(R);
        }
        return list;
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
