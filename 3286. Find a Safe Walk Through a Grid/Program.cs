public class Solution
{
    public bool FindSafeWalk(IList<IList<int>> grid, int health)
    {
        int i = 0, j = 0;
        PriorityQueue<Tuple<int, int>, int> priorityQueue = new PriorityQueue<Tuple<int, int>, int>();
        PriorityQueue<int, int> priorityQueue_paths = new PriorityQueue<int, int>();

        var directions = new (int, int)[] { (0, -1), (0, 1), (-1, 0), (1, 0) };

        List<List<int>> dist = new List<List<int>>();
        for (int row = 0; row < grid.Count; row++)
        {
            dist.Add(new List<int>());
            for (int col = 0; col < grid[row].Count; col++)
                dist[row].Add(int.MaxValue);
        }



        priorityQueue.Enqueue(new Tuple<int, int>(0, 0), grid[0][0]);
        priorityQueue_paths.Enqueue(grid[0][0], grid[0][0]);

        while (priorityQueue.Count > 0 || dist.Last().Last()==int.MaxValue)
        {
            Tuple<int, int> node = priorityQueue.Dequeue();
            if (dist[node.Item1][node.Item2] == int.MaxValue)
                dist[node.Item1][node.Item2] = priorityQueue_paths.Dequeue();
            else
                priorityQueue_paths.Dequeue();

            foreach ((int i1, int j1) in directions)
            {
                if (node.Item1 + i1 >= 0 && node.Item1 + i1 < grid.Count && node.Item2 + j1 >= 0 && node.Item2 + j1 < grid[0].Count && dist[node.Item1 + i1][node.Item2 + j1] == int.MaxValue)
                {
                    priorityQueue.Enqueue(new Tuple<int, int>(node.Item1 + i1, node.Item2 + j1), dist[node.Item1][node.Item2] + grid[node.Item1 + i1][node.Item2 + j1]);
                    priorityQueue_paths.Enqueue(dist[node.Item1][node.Item2] + grid[node.Item1 + i1][node.Item2 + j1], dist[node.Item1][node.Item2] + grid[node.Item1 + i1][node.Item2 + j1]);
                }
            }
        }
        foreach (var x in dist)
        { Console.WriteLine(string.Join(",", x)); }

        return health > dist.Last().Last();
    }
}