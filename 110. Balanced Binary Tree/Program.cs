 
  public class TreeNode {
      public int val;
      public TreeNode right;
      public TreeNode left;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
public class Solution
{
    public int Depth(TreeNode root)
    {
        if (root.left == null && root.right == null)
            return 1;
        else
            if(root.left==null)
                return 1 + Depth(root.right);
        else
            if(root.right==null)
                return 1 + Depth(root.left);

        return 1+ Math.Max(Depth(root.left),Depth(root.right));
    }
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;
        if (root.left == null && root.right == null)
            return true;
        else
            if (root.left == null)
        {
            if (Depth(root.right) > 1 || !IsBalanced(root.right))
                return false;
        }
        else
         if (root.right == null)
        {
            if (Depth(root.left) > 1 || !IsBalanced(root.left))
                return false;
        }
        else
            if (Math.Abs(Depth(root.left) - Depth(root.right)) > 1 || !IsBalanced(root.left) || !IsBalanced(root.right))
                return false;
        return true;
    }
}