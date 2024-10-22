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
    public void Flatten(TreeNode root)
    {
        if (root == null) return;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count>0)
        {
            root = stack.Pop();
            Console.WriteLine(root.val);
            stack2.Push(root);
            if (root.right != null)  stack.Push(root.right); 
            if (root.left !=null)  stack.Push(root.left); 
        }
        TreeNode node= null;TreeNode last = stack2.Pop();
        while (stack2.Count > 0)
        {
            node = stack2.Pop();

            node.right = last;
            node.left = null;

            last = node;
        }
    }
}