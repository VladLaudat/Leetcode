public class Solution
{
    public bool isPalindrome(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        return s.Equals(reversed);
    }
    public string LongestPalindrome(string s)
    {
        if(s.Length==1) return s;
        int i = 0, j = 0;int lastIndex = 0;
        int max = 1;
        while(j<s.Length)
        {
            string substring = s.Substring(i, j + 1);
            if(isPalindrome(substring))
            {
                max = Math.Max(substring.Length,max);
                if (i > 0) i--;
                j++;
                lastIndex = j;
            }
            else
            {
                i=lastIndex;j=lastIndex;
            }
        }
    }
}