public class Solution
{
    public string SimplifyPath(string path)
    {
        Stack<string> stack = new Stack<string>();
        Stack<string> reverseStack = new Stack<string>();
        for(int i=0;i<path.Length;i++)
        {
            while (i<path.Length && path[i] == '/')
                i++;

            int j = i;
            while (i<path.Length && path[i] != '/') i++;

            if (i==j) continue;

            Console.WriteLine(j + ", " + i);
            string folder = path.Substring(j, i-j);
            Console.WriteLine(folder);

            switch (folder)
            {
                case ".": continue;
                case "..": {if(stack.Count>0)stack.Pop(); break;}
                default: { stack.Push(folder); break;}
            }
        }
        while(stack.Count>0) reverseStack.Push(stack.Pop());
        List<string> res = new List<string>();
        while(reverseStack.Count>0) res.Add(reverseStack.Pop());

        return "/"+string.Join("/", res);

    }
}