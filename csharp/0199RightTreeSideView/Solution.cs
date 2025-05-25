public class Solution
{

    public IList<int> RightSideView(TreeNode root)
    {
        Dictionary<int, int?> rightMostByLevel = new Dictionary<int, int?>();
        FillRightMostByLevel(root, 0, rightMostByLevel);

        List<int?> rightMostVals = new List<int?>();
        foreach (var val in rightMostByLevel.Values)
        {
            rightMostVals.Add(val.Value);
        }

        return rightMostVals;
    }

    private void FillRightMostByLevel(TreeNode root, int currLevel, Dictionary<int, int?> rightMostByLevel)
    {
        if (root == null)
        {
            return;
        }
        if (!rightMostByLevel.ContainsKey(currLevel))
        {
            rightMostByLevel[currLevel] = root.val;
        }
        FillRightMostByLevel(root.right, currLevel + 1, rightMostByLevel);
        FillRightMostByLevel(root.left, currLevel + 1, rightMostByLevel);
    }

}