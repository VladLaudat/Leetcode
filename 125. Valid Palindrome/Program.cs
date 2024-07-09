public class Solution
{
    public bool IsPalindrome(string s)
    {
        string alphaNumericCharacters = "abcdefghijklmnopqrstuvxyz0123456789";
        s=s.ToLower();
        int i = 0;
        while(i<s.Length)
        {
            if (!alphaNumericCharacters.Contains(s[i]))
            {
                s=s.Remove(i,1);
            }
            else
            {
                i++;
            }
        }

        string reversed = "";

        for(i = s.Length-1;i>=0;i--)
        {
            reversed+=s[i];
        }

        if(reversed == s)
            return true;
        return false;
    }
}