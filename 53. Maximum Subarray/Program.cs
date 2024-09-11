public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int i = 0, j = 0;
        int sum = 0, maxSum = int.MinValue;
        while(j<nums.Length)
        {
            sum += nums[j];
            if (nums[j]>sum)
            {
                i = j;
                sum = nums[j];
            }
            maxSum = Math.Max(maxSum, sum);
            j++;
        }
        return maxSum;
    }
}