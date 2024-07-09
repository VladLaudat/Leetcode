public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int max = 0, valMin = prices[0];
        if (prices.Length == 1)
            return 0;

        for(int i=0;i<prices.Length;i++)
        {
            if (prices[i]<valMin)
                valMin = prices[i];
            else
            {
                if (prices[i]-valMin > max)
                    max = prices[i]-valMin;
            }
        }
        return max;
    }
}