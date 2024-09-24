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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        if(root==null) return new List<int>();
        if(root.right == null && root.left == null) return new List<int>() { root.val};
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count>0)
        {
            root=stack.Pop();
            result.Add(root.val);
            if (root.right != null) stack.Push(root.right);
            if (root.left !=null) stack.Push(root.left);
        }
        return result;
    }
}