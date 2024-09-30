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
    public IList<int> PostorderTraversal(TreeNode root)
    {
        Stack<TreeNode> stack1 = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();
        List<int> list = new List<int>();
        if(root!=null)
        stack1.Push(root);
        while(stack1.Count>0)
        {
            root=stack1.Pop();stack2.Push(root);
            if(root.left!=null) stack1.Push(root.left);
            if (root.right != null) stack1.Push(root.right);
        }
        while (stack2.Count > 0)
            list.Add(stack2.Pop().val);
        return list;
    }
}