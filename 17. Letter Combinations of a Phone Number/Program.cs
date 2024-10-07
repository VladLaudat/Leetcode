public class Solution
{
    public void Backtracking(string digits, Dictionary<char, string> phoneMapping, List<string> result,List<char> solution , int index)
    {
        if(index==digits.Length)
        {

            result.Add(new string(solution.ToArray()));
            return;
        }
        Console.WriteLine(index);
        Console.WriteLine(digits[index]);
        Console.WriteLine(phoneMapping[digits[index]]);
        foreach (char c in phoneMapping[digits[index]])
        {
            solution.Insert(index,c);
            Backtracking(digits, phoneMapping, result, solution, index + 1);
            solution.RemoveAt(index);
        }
    }
    public IList<string> LetterCombinations(string digits)
    {
        Dictionary<char, string> phoneMapping = new Dictionary<char, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };
        List<string> result = new List<string>();
        List<char> solution = new List<char>();

        if (digits == null || digits.Length==0) return result;

        Backtracking(digits, phoneMapping, result, solution, 0);
        return result;
    }
}