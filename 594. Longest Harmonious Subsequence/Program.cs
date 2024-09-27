public class Solution
{
    public int FindLHS(int[] nums)
    {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach (int x in nums)
        {
            if(!map.ContainsKey(x))
                map.Add(x, 0);
            map[x]++;
        }

        int max = 0;
        foreach(KeyValuePair<int,int> elem in map)
        {
            int nextElem=0;
            map.TryGetValue(elem.Key + 1, out nextElem);
            if(nextElem!=0)
                max=Math.Max(max, elem.Value+nextElem);
        }
        return max;
    }
}