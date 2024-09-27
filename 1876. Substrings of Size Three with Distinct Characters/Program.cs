public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        int i = 0; int res = 0;
        while(i<s.Length-2)
        {
            
            if (s[i] != s[i+1] && s[i] != s[i+2] && s[i+1] != s[i+2])
             res++;
            i++;
        }
        return res;
    }
}