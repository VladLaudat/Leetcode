public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        if (s.Length == 0)
            return 0;
        int result = 0;
        for (int i=0; i<g.Length; i++)
        {
            int smallestCookie = int.MaxValue;
            int smallestCookieIndex = -1;
            for(int j=0;j<s.Length;j++)
            {
                if (s[j] < smallestCookie)
                {
                    if (g[i] <= s[j])
                    { 
                        smallestCookie = s[j];
                        smallestCookieIndex = j;
                    }
                }
            }
            if (smallestCookieIndex != -1)
            { 
                s[smallestCookieIndex] = 0;
                result++;
            }
        }
        return result;
    }
}