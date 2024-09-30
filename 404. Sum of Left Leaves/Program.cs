﻿public class TreeNode {
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
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;
            if(root.left==null && root.right==null) return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int sum = 0;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                root=queue.Dequeue();
                if (root.left == null && root.right == null)
                    sum += root.val;
                if(root.left!=null) queue.Enqueue(root.left);
                if(root.right!=null)
                    if(root.right.left!=null || root.right.right!=null)
                        queue.Enqueue(root.right);
            }
            return sum;

        }
    }