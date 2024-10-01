public class Solution
{
    public bool Backtracking(int[] arr, int k, bool[] visited)
    {
        bool isComplete = true;
        foreach (bool x in visited)
        {
            if (!x) { isComplete = false; break; }
        }
        if (isComplete) return true;
        for (int i = 0; i < arr.Length; i++)
        {
            if (!visited[i])
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (!visited[j] && (arr[i] + arr[j]) % k == 0 && i != j)
                    {
                        visited[j] = visited[i] = true;
                        return Backtracking(arr, k, visited);
                        visited[j] = visited[i] = false;
                    }
                }
            }
        }
        return false;
    }
    public bool CanArrange(int[] arr, int k)
    {
        bool[] visited = new bool[arr.Length];

        for (int i = 0; i < visited.Length; i++)
            visited[i] = false;

        return Backtracking(arr, k, visited);
    }
}