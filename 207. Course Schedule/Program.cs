public class Solution
{
    public bool ContainsCycle(int[][] neighbours, Dictionary<int, bool> visited, Stack<int> recStack, int node)
    {
        visited.Add(node, true);
        recStack.Push(node);
        Console.WriteLine(string.Join(", ", recStack));
        for (int i = 0; i < neighbours[node].Length; i++)
        {
            if (recStack.Contains(neighbours[node][i]))
                return true;
            if (!visited.ContainsKey(neighbours[node][i]))
            {
                if (ContainsCycle(neighbours, visited, recStack, neighbours[node][i]))
                    return true;
            }
        }
        recStack.Pop();
        return false;
    }
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        int[][] neighbours = new int[numCourses][];
        for (int i = 0; i < numCourses; i++)
        {
            neighbours[i] = new int[0];
        }
        for (int i = 0; i < prerequisites.Length; i++)
        {
            Array.Resize(ref neighbours[prerequisites[i][0]], neighbours[prerequisites[i][0]].Length + 1);
            neighbours[prerequisites[i][0]][neighbours[prerequisites[i][0]].Length - 1] = prerequisites[i][1];
        }

        /* for (int i = 0; i < numCourses; i++)
         {
             Console.WriteLine(string.Join(", ", neighbours[i]));
         }*/

        bool res = false;
        for (int i = 0; i < numCourses; i++)
        {
            Console.WriteLine(i);
            if (ContainsCycle(neighbours, new Dictionary<int, bool>(), new Stack<int>(), i))
                return false;

        }
        return true;
    }
}