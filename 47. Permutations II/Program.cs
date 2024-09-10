using System.Collections.Generic;
using System.Globalization;

public class Solution
{
    public static void Main(string[] args)
    {
        int[] ints = { 2, 2, 1, 1 };
        Solution s = new Solution();
        IList<IList<int>> list = s.PermuteUnique(ints);
        foreach(List<int> item in list) 
        {
            Console.WriteLine(string.Join(" ",item));
        }
    }
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        List<IList<int>> response = new List<IList<int>>();
        Backtrack(nums, response, 0);
        return response;
    }
    public void Backtrack(int[] nums, List<IList<int>> response, int level)
    {
        if (level == nums.Length)
        {
            bool contains = false;
            List<int> list = new List<int>(nums);
            foreach (List<int> item in response)
            {
                if(item.SequenceEqual(list))
                    contains = true;
            }
            if(!contains)
                response.Add(list);

        }
        for (int i = level; i < nums.Length; i++)
        {
            if (level != i)
            {
                if (nums[level] != nums[i])
                    {
                        Swap(nums, level, i);
                        Backtrack(nums, response, level + 1);
                        Swap(nums, level, i);
                    }
            }
            else
            { 
                Swap(nums, level, i);
                Backtrack(nums, response, level + 1);
                Swap(nums, level, i);
            }
        }
    }
    public void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}