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
        PriorityQueue<string,int> pqueue = new();
        SerializeHelper(root, pqueue);
        int lastIndex = 0;
        while (pqueue.Count > 0)
        {
            int index;
            string temp;
            pqueue.TryPeek(out temp, out index);
            Console.WriteLine($"i: {index}, val: {temp}");
            //Add index - lastIndex - 1 n's
            for (int i = 0; i < (index - lastIndex - 1); i++)
            {
                data += "n,";
            }
            data += pqueue.Dequeue();
            lastIndex = index;
            if (pqueue.Count > 0)
            {
                data += ',';
            }
        }
        data.TrimEnd(',');
        Console.WriteLine(data);
        return data;
    }

    private void SerializeHelper(TreeNode root, PriorityQueue<string,int> pqueue, int i=0)
    {
        if (root is null)
        {
            return;
        }
        pqueue.Enqueue(root.val.ToString(), i);
        SerializeHelper(root.left, pqueue, 2 * i + 1);
        SerializeHelper(root.right, pqueue, 2 * i + 2);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        if (data.Length == 0)
        {
            return null;
        }
        string[] tree = data.Split(',');
        
        return DeserializeHelper(tree);
    }
    //Takes a string and if that string begins with n returns null, otherwise we create a node using the val

//[1,2,3,null,null,4,5]
    private TreeNode? DeserializeHelper(string[] data, int i = 0)
    {
        //TODO: Split data on commas create an array.
        if (i >= data.Length)
        {
            return null;
        }
        if (data[i] == "n")
        {
            return null;
        }
        int val = int.Parse(data[i]);
        TreeNode root = new TreeNode(val);
        root.left = DeserializeHelper(data, i * 2 + 1);
        root.right = DeserializeHelper(data, i * 2 + 2);
        
        return root;
    }

    private int chartoint(char a)
    {
        return a - '0';
    }

        private static int Left(int i)
    {
        return 2 * i + 1;
    }

    private char IntToChar(int i)
    {
        return (char)(i + (int)'0');
    }

    private static int Right(int i)
    {
        return 2 * i + 2;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
