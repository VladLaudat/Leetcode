public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0 || x == 1) return x;
        int low = 0; int high = x/2; ulong mid = 0;
        while (low <= high)
        {
            mid = (ulong)(low + (high - low) / 2);
            Console.WriteLine(mid);
            if (mid * mid == (ulong)x) return (int)mid;
            if ((mid + 1) * (mid + 1) == (ulong)x) return (int)mid + 1;
            if (mid * mid < (ulong)x && (mid + 1) * (mid + 1) > (ulong)x) return (int)mid;
            if (mid * mid < (ulong)x && (mid + 1) * (mid + 1) < (ulong)x) low = (int)mid + 1;
            if (mid * mid > (ulong)x && (mid + 1) * (mid + 1) > (ulong)x) high = (int)mid - 1;
        }
        return high;
    }
}