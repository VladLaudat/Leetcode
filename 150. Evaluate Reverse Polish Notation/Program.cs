public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
        List<string> operators = new List<string>() { "+", "*", "-", "/" };
        
        foreach (string token in tokens)
        {
            bool isOperator = false;
            for (int i = 0; i < 4; i++)
            {
                if (operators[i].SequenceEqual(token))
                {
                    isOperator = true;
                    int nr2 = stack.Pop();
                    int nr1 = stack.Pop();

                    switch (i)
                    {
                        case 0: { stack.Push(nr1 + nr2); break; }
                        case 1: { stack.Push(nr1 * nr2); break; }
                        case 2: { stack.Push(nr1 - nr2); break; }
                        case 3: { stack.Push(nr1 / nr2); break; }
                    }
                    break;
                }
            }
            if(!isOperator)
            {
                int operand = int.Parse(token);
                stack.Push(operand);
            }
        }
        return stack.Pop();
    }
}