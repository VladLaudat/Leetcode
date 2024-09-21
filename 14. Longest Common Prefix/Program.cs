public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1) return strs[0];
        if (strs[0].Length == 0) return "";
        List<char> prefix = new List<char>();
        int i = 0; bool finished = false;
        while (true)
        {
            if (i >= strs[0].Length)
            { finished = true; break; }
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length)
                { finished = true; break; }
                if (strs[j][i] != strs[0][i])
                { finished = true; break; }
            }
            if (finished)
                break;
            prefix.Add(strs[0][i]);
            Console.WriteLine(string.Concat(prefix));
            i++;
        }
        return string.Concat(prefix);
    }
}