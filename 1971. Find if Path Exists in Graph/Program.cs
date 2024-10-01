public class Solution
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        int[][] graph = new int[n][];

        for (int i = 0; i < n; i++)
        {
            graph[i] = new int[n];
        }
        for (int i = 0; i < edges.Length; i++)
        {
            graph[edges[i][0]][edges[i][1]] = graph[edges[i][1]][edges[i][0]] = 1;
        }
        bool[] visited = new bool[n];

        for (int i = 0; i < n; i++)
        {
            visited[i]=false;
        }
            Stack<int> stack = new Stack<int>();

         stack.Push(source); visited[source] = true;
        
            while (stack.Count > 0)
            {
                int node = stack.Pop();
                
                for (int i = 0; i < n; i++)
                    if (graph[node][i] == 1)
                    {
                    if (!visited[i])
                        { stack.Push(i); visited[i] = true; }
                    }
            }
         return visited[source] == visited[destination];
    }
}