public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if(n==1) return new List<int> { 0 };

        List<int> result = new List<int>();
        int[] weights = new int[n];

        Dictionary<int, List<int>> adacencyList = new Dictionary<int, List<int>>();

        for(int i=0;i<n;i++) weights[i] = 0;

        for (int i = 0; i < edges.Length; i++)
        {
            weights[edges[i][0]]++; 
            weights[edges[i][1]]++;

            adacencyList.TryAdd(edges[i][0], new List<int>());
            
            adacencyList.TryAdd(edges[i][1], new List<int>());
            

            adacencyList[edges[i][0]].Add(edges[i][1]);
            adacencyList[edges[i][1]].Add(edges[i][0]);
        }
        Queue<int> queue = new Queue<int>();
        for(int i=0;i<weights.Length;i++)
        {
            if (weights[i]==1)
                queue.Enqueue(i);
        }
        int processed = 0;
        while(n-processed>2)
        {
            int size = queue.Count;
            processed +=size;
            for (int i = 0; i < size; i++)
            {
                int leaf = queue.Dequeue(); weights[leaf]--;
                foreach (int key in adacencyList[leaf])
                {
                   weights[key]--;
                   if (weights[key] == 1) queue.Enqueue(key);
                    
                }
            }
        }
        while(queue.Count>0) result.Add(queue.Dequeue());
        return result;
    }
}