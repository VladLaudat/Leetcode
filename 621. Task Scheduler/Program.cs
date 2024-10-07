public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        int res=0;
        Dictionary<char, int> letterApparitions = new Dictionary<char, int>();
        Dictionary<char, int> letterDownTime = new Dictionary<char, int>();
        PriorityQueue<char, int> priorityQueue = new PriorityQueue<char, int>();

        foreach (char task in tasks)
        {
            if (!letterApparitions.TryAdd(task, 1))
                letterApparitions[task]++;
            letterDownTime.TryAdd(task, 0);
        }
        foreach (var key in letterApparitions.Keys)
            priorityQueue.Enqueue(key, (-1) * letterApparitions[key]);
        int i = 0; bool idle = true;
        while(i<tasks.Length)
        {
            res++;
            foreach (var key in letterApparitions.Keys.OrderBy(k => (-1)*letterApparitions[k])) 
            {
                
                if (letterDownTime[key] == 0 && idle==true && letterApparitions[key] >0)
                { 
                    idle=false;
                    letterApparitions[key] -= 1;
                    letterDownTime[key] = n;
                    Console.WriteLine(key);
                }
                else if (letterDownTime[key] > 0)
                {
                    letterDownTime[key]--;
                }
            }
            if (!idle) i++;
            if (idle) Console.WriteLine("idle");
            idle = true;
        }
        return res;
    }
}