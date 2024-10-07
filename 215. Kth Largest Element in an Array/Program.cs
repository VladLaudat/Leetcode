public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

        foreach (int x in nums)
        {
            priorityQueue.Enqueue(-x,-x);
        }
        for(int i=1;i<=k-1;i++)
            priorityQueue.Dequeue();
        return -priorityQueue.Dequeue();
    }
}