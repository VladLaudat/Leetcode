public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = ((nums.Length + 1) * nums.Length)/2;
        foreach(int num in nums)
        {
            n=n-num;
        }
        return n;
    }
}