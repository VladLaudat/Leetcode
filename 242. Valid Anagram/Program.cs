public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        Dictionary<char, int> letters= new Dictionary<char, int>();

        foreach(char c in alphabet)
        {
            letters.Add(c, 0);
        }

        foreach(char c in s)
        {
            letters[c]++;
        }

        foreach(char c in t)
        {
            letters[c]--;
        }

        foreach(int value in letters.Values)
        {
            if(value!=0)
                return false;
        }
        return true;
    }
}