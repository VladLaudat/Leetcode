public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        PriorityQueue<int[], int> priorityQueue = new PriorityQueue<int[], int>();
        int[][] result = new int[k][];
        for (int i = 0; i < points.Length; i++)
        {
            int point = points[i][0] * points[i][0] + points[i][1] * points[i][1];
            priorityQueue.Enqueue(new int[2] { points[i][0], points[i][1] }, point);
        }
        for (int i = 0; i < k; i++)
        {
            result[i] = priorityQueue.Dequeue();
        }
        return result;
    }
}