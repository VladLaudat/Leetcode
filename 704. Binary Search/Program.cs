﻿public class Solution
{
    public int Search(int[] nums, int target)
    {
        int i=0, j=nums.Length-1;
        while (i <= j)
        {
            int mid = (i + j) / 2;
            
                if (target < nums[mid])
                    j = mid-1;
                else
                if(target > nums[mid])
                    i = mid+1;
                else
                    return mid;
        }
        return -1;
    }
}