public class Solution
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        IList<IList<int>> ints = s.Generate(3);
        foreach (List<int> ints1 in ints)
        {
            Console.WriteLine(string.Join(" ", ints1));
        }
    }
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> list = new List<IList<int>>();
        list.Add(new List<int> { 1 });

        if (numRows == 1)
            return list;

        list.Add(new List<int> { 1, 1 });

        if (numRows == 2)
            return list;

        for(int i=2;i<numRows;i++)
        {
            List<int> row = new List<int>() { 1 };
            for (int j = 1; j < i; j++)
                row.Add(list[i - 1][j-1] + list[i - 1][j]);
            row.Add(1);
            list.Add(row);
        }
        return list;
    }
}