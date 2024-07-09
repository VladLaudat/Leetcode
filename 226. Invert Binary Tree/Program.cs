
 
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
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return root;
        if(!(root.left!=null || root.right!=null))
        {
            root.right = InvertTree(root.right);
            root.left = InvertTree(root.left);

            TreeNode copy = root.left;
            root.left = root.right;
            root.right = copy;
        }
        return root;
    }
}