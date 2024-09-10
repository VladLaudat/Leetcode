public class Solution
{
    public int ArrayPairSum(int[] nums)
    {
        int sum = 0;
        Array.Sort<int>(nums);
        for(int i=0; i<nums.Length;i=i+2)
        {
            sum+= nums[i];
        }
        return sum;
    }
}