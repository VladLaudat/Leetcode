public class Solution
{
    public void Backtracking(int n, List<string> result, List<char> parantheses, int paranthesesToClose, int paranthesesToOpen)
    {
        Console.WriteLine(new string(parantheses.ToArray()));
        if (parantheses.Count == n * 2 && paranthesesToClose==0) result.Add(new string(parantheses.ToArray()));

        if(paranthesesToOpen>0)
        {
            parantheses.Insert(parantheses.Count,'(');
        Backtracking(n, result, parantheses, paranthesesToClose+1, paranthesesToOpen-1);
            parantheses.RemoveAt(parantheses.Count - 1);
        }

        if (paranthesesToClose > 0 && paranthesesToClose <= n)
        {parantheses.Insert(parantheses.Count, ')');
        Backtracking(n, result, parantheses, paranthesesToClose-1, paranthesesToOpen);
            parantheses.RemoveAt(parantheses.Count - 1);
        }

    }
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> result = new List<string>();
        List<char> parantheses = new List<char>();

        Backtracking(n, result, parantheses, 0,n);

        return result;
    }
}