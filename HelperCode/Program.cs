public class Solution
{
    public int Search(int[] nums, int target)
    {
        int start = 0;int end = nums.Length - 1;int middle = 0;
        while (start <= end)
        {
            middle = start + (end - start) / 2;
            if (nums[middle] == target) return middle;
            if (target > nums[middle]) start = middle + 1;
            if(target < nums[middle]) end = middle-1;
        }
        return -1;

    }
}