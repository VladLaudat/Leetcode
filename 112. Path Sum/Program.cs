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
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if(root == null) return false;  
        Stack<TreeNode> stack = new Stack<TreeNode>();
        Dictionary<TreeNode, int> levels = new Dictionary<TreeNode, int>();

        stack.Push(root);
        levels.Add(root, root.val);

        while(stack.Count>0)
        {
            root=stack.Pop();
            if (root.left == null && root.right == null)
            {
                if (levels[root]==targetSum)
                    return true;
            }
            if(root.left != null)
            {
                stack.Push(root.left);
                levels.Add(root.left, levels[root] + root.left.val);
            }
            if(root.right!=null)
            {
                stack.Push(root.right);
                levels.Add(root.right, levels[root] + root.right.val);
            }
        }
        return false;
    }
}