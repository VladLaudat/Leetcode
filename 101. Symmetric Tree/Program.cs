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
    public bool IsSymmetric(TreeNode root)
    {
        if(root==null) return false;
        if((root.right==null)!=(root.left==null)) return false;
        if(root.right==null && root.left==null) return true;

        Stack<TreeNode> subTreeLeft = new Stack<TreeNode>();
        Stack<TreeNode> subTreeRight = new Stack<TreeNode>();
        TreeNode rootLeft = root.left;
        TreeNode rootRight = root.right;

        while(subTreeLeft.Count>0 && subTreeRight.Count>0 || rootLeft!=null || rootRight!=null)
        {
            while(rootLeft!=null || rootRight!=null)
            {
                if ((rootRight == null) != (rootLeft == null)) return false;
                if (rootLeft!=null)
                {subTreeLeft.Push(rootLeft);
                    rootLeft = rootLeft.left;
                }
                if(rootRight!=null)
                {subTreeRight.Push(rootRight);
                    rootRight = rootRight.right;
                }
            }
            rootLeft = subTreeLeft.Pop();
            rootRight = subTreeRight.Pop();
            if(rootLeft.val!=rootRight.val) return false;
            rootLeft = rootLeft.right;
            rootRight = rootRight.left;
        }
        return true;
    }
}