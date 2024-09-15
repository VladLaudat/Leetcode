public class Solution
{
        public int Rob_I(int[] nums)
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
    
    public int Rob(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        list1=nums.ToList();
        list2 = nums.ToList();
        list1.RemoveAt(nums.Length - 1);
        list2.RemoveAt(0);

        return Math.Max(Rob_I(list1.ToArray()), Rob_I(list2.ToArray()));
    }
}