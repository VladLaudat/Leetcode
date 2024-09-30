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
    public int MinDepth(TreeNode root)
    {
        if(root == null) return 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        Dictionary<TreeNode, int> levels = new Dictionary<TreeNode, int>();

        queue.Enqueue(root);
        levels.Add(root, 1);
        while (queue.Count > 0)
        {
            root = queue.Dequeue();
            if (root.right == null && root.left == null) return levels[root];

            if(root.left!=null)
            {
                queue.Enqueue(root.left);
                levels.Add(root.left, levels[root]+1);
            }
            if (root.right != null)
            {
                queue.Enqueue(root.right);
                levels.Add(root.right, levels[root] + 1);
            }
        }
        return 0;
    }
}