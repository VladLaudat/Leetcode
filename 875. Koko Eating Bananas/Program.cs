public class Solution
{
    public long TotalHours(int[] piles,int speed)
    {
        long sum = 0;
        for (int i=0;i<piles.Length;i++)
        {
            sum += ((piles[i]-1)/speed)+1;
        }
        return sum;

    }
    public int MinEatingSpeed(int[] piles, int h)
    {
        int low = 1; int high = -1;
        foreach (int pile in piles)
        {
            if (pile > high) high = pile;
        }

        while(low<=high)
        {
            int mid = low + (high-low)/2; long totalHours= TotalHours(piles,mid);
            if (totalHours <= h)
            {
                high = mid-1;
            }
            else
            {
                low = mid+1;
            }
        }
        return low;
    }
}