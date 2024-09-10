public class Solution
{
    public int LongestPalindrome(string s)
    {
        if (s.Length == 1)
            return 1;
        Dictionary<char, int > letterCounter = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!letterCounter.ContainsKey(c))
                letterCounter.Add(c,0);
            letterCounter[c]++;
           
        }
        char? remainingValue1Key = null;
        int response = 0;
        foreach(KeyValuePair<char, int> element in letterCounter)
        {
            if (element.Value%2==1)
            {
                if(remainingValue1Key == null)
                {
                    remainingValue1Key = element.Key;
                    response += element.Value;
                }
                else
                {
                    response+=element.Value-1;
                }
            }
            if (element.Value % 2 == 0)
                response += element.Value;
        }
        return response;
    }
}