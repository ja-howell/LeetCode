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
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        var (isValid, minVal, maxVal) = ValidateBST(root);
        return isValid;
    }

    private static (bool, int?, int?) ValidateBST(TreeNode? root)
    {
        if (IsLeaf(root))
        {
            return (true, root?.val, root?.val);
        }
        bool rootIsValid;
        int? totalMinVal = root?.val;
        int? totalMaxVal = root?.val;
        //check left
        if (root.left != null)
        {
            var (isValid, minVal, maxVal) = ValidateBST(root.left);
            if (!isValid)
            {
                return (false, -1, -1);
            }
            if (root.val <= maxVal)
            {
                return (false, -1, -1);
            }
            totalMinVal = minVal;
        }
        //check right
        if (root.right != null)
        {
            var (isValid, minVal, maxVal) = ValidateBST(root.right);
            if (!isValid || root.val >= minVal)
            {
                return (false, -1, -1);
            }
            totalMaxVal = maxVal;
        }

        return (true, totalMinVal, totalMaxVal);
    }

    private static bool IsLeaf(TreeNode root)
    {
        return (root.left == null && root.right == null);
    }
}