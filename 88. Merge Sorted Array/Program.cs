public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = 0;int j = 0;int k = m;
        while(i<k && j<n)
        {
            if (nums2[j] < nums1[i])
            {
               for(int index=k;index>i;index--)
                    nums1[index] = nums1[index-1];
                nums1[i] = nums2[j];
                j++;k++;
            }
            i++;
        }
        while(k<m+n && j<n)
        {
            nums1[k++]= nums2[j++];
        }
    }
}