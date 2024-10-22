public class Solution
{
    public int FindMin(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        int firstElem = nums[0];
        int low = 0, high = nums.Length - 1;
        int mid = 0;
        while (low <= high)
        {
            mid = low + (high - low) / 2;
            if (low == high && nums[mid] < firstElem) return nums[mid];
            if (nums[mid] >= firstElem)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }
        if (nums[mid] < firstElem) return nums[mid];
        return nums[0];
    }
}