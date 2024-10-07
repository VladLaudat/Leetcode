public class Solution
{
    public void Backtracking(int[] candidates, int target, int currentSum, List<int> sum, List<IList<int>> result,int index)
    {
        if (currentSum > target) return;
        if (currentSum == target) 
        {
            List<int> res = new List<int>(sum);
            result.Add(res);
            return;
        }
        int prev = -1;
        for(int i=index;i<candidates.Length;i++)
        {
            if (candidates[i] == prev) continue;
            sum.Add( candidates[i]); currentSum += candidates[i];
            Backtracking(candidates, target, currentSum, sum, result,i+1);
            sum.RemoveAt(sum.Count-1); currentSum -= candidates[i];
            prev=candidates[i];
            
        }

    }
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> result = new List<IList<int>>();
        List<int> sum = new List<int>();
        Array.Sort(candidates);

        Backtracking(candidates, target, 0, sum, result,0);

        return result;
    }
}