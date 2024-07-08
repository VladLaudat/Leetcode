public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> opposites = new Dictionary<char,char>();
        opposites['('] = ')';
        opposites['['] = ']';
        opposites['{'] = '}';
        foreach(char c in s)
        {
            if(opposites.Keys.Contains(c))
            {
                stack.Push(c);
            }
            else
            {
                if(stack.Count==0)
                    return false;
                if (c != opposites[stack.Peek()])
                    return false;
                stack.Pop();
            }
        }
        if (stack.Count == 0)
            return true;
        return false;
    }
}