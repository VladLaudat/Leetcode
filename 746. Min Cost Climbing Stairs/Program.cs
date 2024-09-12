public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int i = 0;
        int minCost = 0;
        if (cost[0] > cost[1])
            i = 1;
        minCost = Math.Min(cost[0], cost[1]);

        while (i<cost.Length-2)
        {
            minCost = minCost + Math.Min(cost[i + 1], cost[i + 2]);
            if (cost[i+1] < cost[i+2])
                i=i+1;
            else
                i = i+2;
        }
    }
}