public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if(nums.Length==1) return false;
        int i = 0, j = 1;
        while (i < nums.Length - 1)
        {
            while(j-i<=k && j<nums.Length)
            {
                if (nums[i] == nums[j])return true;
                j++;
            }
            i++;
            j = i + 1;
        }
        return false;
    }
}