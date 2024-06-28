public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0; int[] changedArray = new int[nums.Length];

        foreach (int i in nums)
        {
            if (i != val)
            {

                changedArray[k++] = i;
            }
        }
        nums = changedArray;

        return k;
    }
}