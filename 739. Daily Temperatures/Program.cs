public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        Array.Fill(result, 0);
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                result[stack.Peek()] = i - stack.Pop();
            }
            stack.Push(i);
        }
        return result;
    }
}