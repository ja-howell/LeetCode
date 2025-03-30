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
using System.Text;
public class Codec
{

    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        StringBuilder sb = new();
        PriorityQueue<string,int> pqueue = new();
        SerializeHelper(root, pqueue);
        int lastIndex = 0;
        while (pqueue.Count > 0)
        {
            int index;
            string temp;
            pqueue.TryPeek(out temp, out index);
            pqueue.Dequeue();
            sb.Append($"{index}:{temp}");
            if (pqueue.Count > 0)
            {
                sb.Append(',');
            }
            lastIndex = index;
        }
        return sb.ToString();
    }

    private static void SerializeHelper(TreeNode root, PriorityQueue<string,int> pqueue, int i=0)
    {
        if (root is null)
        {
            return;
        }
        Console.WriteLine($"({root.val.ToString()}, {i})");
        pqueue.Enqueue(root.val.ToString(), i);
        SerializeHelper(root.left, pqueue, 2 * i + 1);
        SerializeHelper(root.right, pqueue, 2 * i + 2);
    }

    // Decodes your encoded data to tree.
    public TreeNode? deserialize(string data)
    {
        Console.WriteLine(data);
        if (data.Length == 0)
        {
            return null;
        }

        Dictionary<int, TreeNode> indexNodeMapping = new();

        string[] keyValuePairs = data.Split(',');

        int index;
        int val;
        (index, val) = SplitKeyValuePair(keyValuePairs[0]);
        indexNodeMapping[index] = new TreeNode(val);

        for (int i = 1; i < keyValuePairs.Length; i++)
        {
            (index, val) = SplitKeyValuePair(keyValuePairs[i]);

            // Console.WriteLine($"({index}, {val})");
            indexNodeMapping[index] = new TreeNode(val);
            int parent = Parent(index);

            if (index % 2 == 1)
            {
                indexNodeMapping[parent].left = indexNodeMapping[index];
            }
            else
            {
                indexNodeMapping[parent].right = indexNodeMapping[index];
            }
        }
        return indexNodeMapping[0];
    }

    private (int, int) SplitKeyValuePair(string kv)
    {
        string[] parts = kv.Split(':');
        return (int.Parse(parts[0]), int.Parse(parts[1]));
    }

    private static int Parent(int i)
    {
        return (i - 1) / 2;
    }

}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
