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
    public TreeNode ReverseOddLevels(TreeNode root)
    {
        Dfs(root.left, root.right, 0);
        return root;
    }

    private void Dfs(TreeNode leftChild, TreeNode rightChild, int level)
    {
        if (leftChild == null || rightChild == null)
        {
            return;
        }

        if (level % 2 == 0)
        {
            int temp = leftChild.val;
            leftChild.val = rightChild.val;
            rightChild.val = temp;
        }

        Dfs(leftChild.left, rightChild.right, level + 1);
        Dfs(leftChild.right, rightChild.left, level + 1);
    }
}