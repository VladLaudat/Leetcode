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
    public int LeftHeight(TreeNode root)
    {
        int count = 0;
        while(root!=null)
        {
            count++;
            root = root.left;
        } return count;
    }
    public int RightHeight(TreeNode root)
    {
        int count = 0;
        while (root != null)
        {
            count++;
            root = root.right;
        } return count;
    }
    public int CountNodes(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        int lh = LeftHeight(root.left);
        int rh = RightHeight(root.right);
        if (lh == rh) { return 1<<(lh+1)-1; }
        return 1+ CountNodes(root.left)+CountNodes(root.right);
    }
}