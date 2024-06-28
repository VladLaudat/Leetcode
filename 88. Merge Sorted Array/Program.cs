
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = 0; int j = 0; int k = 0; ; int[] array = new int[m + n];
        while (i < m + n)
        {

            if (m != 0 && n != 0)
            {
                if (nums1[j] < nums2[k])
                {
                    array[i++] = nums1[j];
                    if (j < m)
                        j++;
                }
                else
            if (n != 0)
                {
                    array[i++] = nums2[k];
                    if (k < n)
                        k++;
                }
            }
        }
        nums1 = array;
    }
}