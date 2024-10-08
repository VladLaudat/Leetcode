﻿public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int low = 0; int high = nums.Length - 1; int mid = 0;

        while (low <= high)
        {
            mid=low + (high-low)/2;
            if (target == nums[mid]) return mid;
            if(target > nums[mid]) low = mid+1;
            if(target< nums[mid]) high = mid-1; 
        }
        return low;
    }
}