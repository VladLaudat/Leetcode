using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

public class Djikstra
{

    //* Not using heap
    /*public int ChooseNode(int[] dist, bool[] visited)
{
  int min = int.MaxValue; int index = -1;
  for (int i = 0; i < dist.Length; i++)
  {
      if (!visited[i] && dist[i] <= min)
      {
          min = dist[i];
          index = i;
      }
  }
  return index;
}
public int[] Algorithm(int[][] graph, int source)
{
  bool[] visited = new bool[graph.Length];
  int[] dist = new int[graph.Length];

  for (int i = 0; i < graph.Length; i++)
  {
      visited[i] = false;
      dist[i] = int.MaxValue;
  }

  dist[source] = 0;

  for (int i = 0; i < graph.Length; i++)
  {
      int node = ChooseNode(dist, visited);

      visited[node] = true;

      for (int j = 0; j < graph.Length; j++)
      {
          if (graph[node][j] != 0 && graph[node][j] + dist[node] < dist[j] && !visited[j])
          {
              dist[j] = dist[node] + graph[node][j];
          }
      }
  }

  return dist;

}*/
    //With heap(priority queue)

    public int[] Algorithm(int[][] graph, int source)
    {
        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
        PriorityQueue<int, int> priorityQueue_paths = new PriorityQueue<int, int>();
        int[] dist = new int[graph.Length];
        for (int i = 0; i < graph.Length; i++)
            dist[i] = int.MaxValue;
            

        priorityQueue.Enqueue(source,0);
        priorityQueue_paths.Enqueue(0,0);

        while(priorityQueue.Count>0)
        {
           int node = priorityQueue.Dequeue();
           int path = priorityQueue_paths.Dequeue();

            if(dist[node]== int.MaxValue)
                dist[node] = path;

            Console.WriteLine("Node " + (node+1));
            Console.WriteLine(string.Join(", ", dist));

            for(int i=0;i<graph.Length;i++)
            {
                if (graph[node][i]!=0 && dist[i]==int.MaxValue)
                {
                    priorityQueue.Enqueue(i, graph[node][i] + dist[node]);
                    priorityQueue_paths.Enqueue(graph[node][i] + dist[node], graph[node][i] + dist[node]);
                }
            }
        }
        return dist;
    }
    public static void Main(string[] args)
    {
        int[][] graph = new int[][] {
    new int[] { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
    new int[] { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
    new int[] { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
    new int[] { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
    new int[] { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
    new int[] { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
    new int[] { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
    new int[] { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
    new int[] { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
    };


        Djikstra djikstra = new Djikstra();

        Console.WriteLine(string.Join(", ", djikstra.Algorithm(graph, 0)));
    }
}