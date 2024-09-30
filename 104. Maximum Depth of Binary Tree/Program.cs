public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        Dictionary<TreeNode, int> depths = new Dictionary<TreeNode, int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();

        stack.Push(root);
        depths.Add(root, 1);
        int max = 1;
        while (stack.Count > 0)
        {
            root = stack.Pop();

            if (root.right != null)
            {
                stack.Push(root.right);
                depths.Add(root.right, depths[root] + 1);
                max = Math.Max(max, depths[root] + 1);
            }
            if (root.left != null)
            {
                stack.Push(root.left);
                depths.Add(root.left, depths[root] + 1);
                max = Math.Max(max, depths[root] + 1);
            }
        }

        return max;
    }
}