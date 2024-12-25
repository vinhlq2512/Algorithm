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
public class Solution {
    public IList<int> LargestValues(TreeNode root)
    {
        IList<int> result = new List<int>();
        if(root == null)
        {
            return result;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var totalSwaps = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            var levelValues = new int[levelSize];

            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                levelValues[i] = node.val;

                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            result.Add(GetMaxValue(levelValues));
        }
        return result;
    }

    public int GetMaxValue(int[] levelValues)
    {
        int max = levelValues[0];
        for (int i = 1; i < levelValues.Length; i++)
        {
            if (levelValues[i] > max)
            {
                max = levelValues[i];
            }
        }
        return max;
    }
}