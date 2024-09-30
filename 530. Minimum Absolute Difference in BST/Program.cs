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
    public int GetMinimumDifference(TreeNode root)
    {
        TreeNode root2 = root;
        Stack<TreeNode> stack1 = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();
        int dif = int.MaxValue;
        stack1.Push(root);
        while(stack1.Count>0)
        {
            root = stack1.Pop();
            root2 = root;
            stack2.Push(root2);
            while (stack2.Count > 0)
            {
                root2 = stack2.Pop();
                if(root!=root2)
                    dif = Math.Min(dif,Math.Abs(root.val-root2.val));

                if (root2.left != null) { stack2.Push(root2.left); }
                if (root2.right != null) { stack2.Push(root2.right); }
            }

            if (root.left!=null) { stack1.Push(root.left); }
            if (root.right != null) { stack1.Push(root.right); }
        }
        return dif;
    }
}