/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
#nullable enable
public class Codec
{

    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        string data = "";
        Queue<TreeNode?> tree = new();
        tree.Enqueue(root);
        while (tree.Count > 0)
        {
            TreeNode temp = tree.Dequeue();
            if (temp is null)
            {
                data += "n";
            }
            else
            {
                data += temp.val.ToString();
                tree.Enqueue(temp.left);
                tree.Enqueue(temp.right);
            }
        }
        Console.WriteLine(data);
        return data;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
         return DeserializeHelper(string data);
    }

    private TreeNode? DeserializeHelper(string data)
    {
        if (data[0] == 'n')
        {
            return null;
        }
        int val = chartoint(data[0]);
        TreeNode root = new TreeNode(val);
        if (data.Length >= 2)
        {
            root.left = DeserializeHelper(data.Substring(1));
        }
        if (data.Length >= 3)
        {
            root.right = DeserializeHelper(data.Substring(2));
        }
        
        return root;
    }

    private int chartoint(char a)
    {
        return a - '0';
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));

