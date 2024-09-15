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

    }
}