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
    public void Backtracking(TreeNode root, List<TreeNode> path, List<string> paths)
    {
        if(root==null) return;
        if (root.left == null && root.right == null)
        {
            path.Add(root);
            paths.Add(string.Join("->", path.Select(p => p.val)));
            path.Remove(root);
        }
        else
        {
            
            path.Add(root);
            if(root.left!=null)
                Backtracking(root.left, path, paths);
            
            if (root.right != null)
                Backtracking(root.right, path, paths);
            path.Remove(root);
        }
            

    }
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        List<string> paths = new List<string>();
        List<TreeNode> path = new List<TreeNode>();

        Backtracking(root, path, paths);
        return paths;
    }
}