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
//DFS Variant
/*public class Solution
{
    public bool DFS(TreeNode p, TreeNode q, Dictionary<TreeNode, bool> visitedP, Dictionary<TreeNode, bool> visitedQ)
    {
        if(p==null && q==null) return true;
        if(p==null || q==null) return false;
        bool left=true, right=true;
        visitedP.Add(p, true);
        visitedQ.Add(q, true);
        if(p.val!=q.val) return false;
        if((p.left!=null) != (q.left!=null)) return false;
        if ((p.right != null) != (q.right != null)) return false;

        if (p.left != null && q.left != null)
            if (!visitedP.ContainsKey(p.left) && !visitedQ.ContainsKey(q.left))
                 left = DFS(p.left, q.left, visitedP, visitedQ);
        if (p.right != null && q.right != null)
            if (!visitedP.ContainsKey(p.right) && !visitedQ.ContainsKey(q.right))
                right = DFS(p.right, q.right, visitedP, visitedQ);

        return left && right;
    }
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        Dictionary<TreeNode, bool> visitedP = new Dictionary<TreeNode, bool>();
        Dictionary<TreeNode, bool> visitedQ = new Dictionary<TreeNode, bool>();

        return DFS(p, q, visitedP, visitedQ);

    }
}*/

//BSF Variant
public class Solution
{
    public bool BFS(TreeNode p, TreeNode q, Dictionary<TreeNode, bool> visitedP, Dictionary<TreeNode, bool> visitedQ)
    {
        if(q==null && p==null) return true;
        if(q==null || p==null) return false;
        Queue<TreeNode> queueP = new Queue<TreeNode>();
        Queue<TreeNode> queueQ = new Queue<TreeNode>();
        queueP.Enqueue(p);visitedP.Add(p,true);
        queueQ.Enqueue(q);visitedQ.Add(q,true);

        while (queueP.Count > 0 && queueQ.Count>0)
        {
            p= queueP.Dequeue();
            q= queueQ.Dequeue();
            if(p.val!=q.val) return false;
            if((p.left==null) != (q.left==null)) return false;
            if ((p.right == null) != (q.right == null)) return false;

            if (p.left != null && q.left != null)
                if (!visitedP.ContainsKey(p.left) && !visitedQ.ContainsKey(q.left))
                    {queueP.Enqueue(p.left);queueQ.Enqueue(q.left); }
            if (p.right != null && q.right != null)
                if (!visitedP.ContainsKey(p.right) && !visitedQ.ContainsKey(q.right))
                { queueP.Enqueue(p.right); queueQ.Enqueue(q.right); }
        }
        return true;
    }
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        Dictionary<TreeNode, bool> visitedP = new Dictionary<TreeNode, bool>();
        Dictionary<TreeNode, bool> visitedQ = new Dictionary<TreeNode, bool>();

        return BFS(p, q, visitedP, visitedQ);

    }
}