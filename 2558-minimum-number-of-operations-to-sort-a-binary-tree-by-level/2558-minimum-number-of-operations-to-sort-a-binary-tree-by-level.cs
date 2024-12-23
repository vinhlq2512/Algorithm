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
    public int MinimumOperations(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var totalSwaps = 0;

        while (queue.Count > 0) {
            int levelSize = queue.Count;
            var levelValues = new int[levelSize];

            for (int i = 0; i < levelSize; i++) {
                var node = queue.Dequeue();
                levelValues[i] = node.val;

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            totalSwaps += GetMinSwaps(levelValues);
        }
        return totalSwaps;
    }
    
    private int GetMinSwaps(int[] original) {
        int swaps = 0;
        var target = (int[])original.Clone();
        Array.Sort(target);

        var pos = new Dictionary<int, int>();
        for (int i = 0; i < original.Length; i++) {
            pos[original[i]] = i;
        }

        for (var i = 0; i < original.Length; i++)
        {
            if (original[i] == target[i]) continue;
            
            swaps++;
            var curPos = pos[target[i]];
            pos[original[i]] = curPos;
            original[curPos] = original[i];
        }
        return swaps;
    }
}