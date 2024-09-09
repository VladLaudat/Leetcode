public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> response = new List<IList<int>>();
        List<int> permutation = new List<int>();
        bool[] used = new bool[nums.Length];
        Backtrack(nums, response, 0, permutation, used);
        return response;
    }
    public void Backtrack(int[] nums, IList<IList<int>> response,int level, List<int> permutation, bool[] used)
    {
        if (level==nums.Length)
        {
            List<int> list = new List<int>(permutation);
            response.Add(list);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (!used[i])
            {
                permutation.Add(nums[i]); used[i] = true;
                Backtrack(nums, response, level + 1, permutation, used);
                permutation.Remove(nums[i]); used[i]= false;
            }
        }
    }
}