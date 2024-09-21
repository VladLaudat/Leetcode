    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length==1) return 1;
            int i = 0;int j = 1;
            int newLen = 1;
            while(j<nums.Length)
            {
                if (nums[i] == nums[j])
                {
                    j++;
                }
                else
                {
                    newLen++;
                    nums[newLen - 1] = nums[j];
                    i = j;
                }
            }
            return newLen;

        }
    }