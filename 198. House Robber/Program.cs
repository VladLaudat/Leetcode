public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        int max = nums[0];

        for (int i = 2; i < nums.Length; i++)
        {
            nums[i] += max;
            max = Math.Max(max, nums[i - 1]);
        }
        return Math.Max(nums[nums.Length - 1], nums[nums.Length - 2]);
    }
}