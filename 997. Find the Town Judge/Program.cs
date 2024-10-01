public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        if (n == 1) return 1;
        if(trust.Length==0) return -1;

        int[] trustCount = new int[n];

        for(int i=0;i<n;i++)
        {
            trustCount[i] = 0;
        }

        for(int i=0;i<trust.Length;i++)
        {
            trustCount[trust[i][0] - 1]--;
            trustCount[trust[i][1]-1]++;
        }

        for (int i = 0; i < n; i++)
        {
            if(trustCount[i] == n - 1)
                return i+1;
        }
        return -1;
    }
}