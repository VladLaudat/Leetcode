public class Solution
{
    public void Backtracking(int turnedOn, bool[] H, bool[] M, List<string> result)
    {
        if(turnedOn==0)
        {
            int hour=0, minute=0;
            for(int i=0; i<H.Length;i++)
            {
                if (H[i])
                    hour += 1<<(i);
            }
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i])
                    minute += 1 << (i);
            }
            if(hour>11) return;
            if (minute > 59) return;
            string time = string.Format("{0}:{1:D2}", hour, minute);
            if (hour == 0 && minute == 0) time = "0:00";
            if(!result.Contains(time))
                result.Add(time);
        }
        else
        {
            for(int i=0;i<M.Length;i++)
            {
                if(!M[i])
                { 
                    M[i] = true;
                    Backtracking(turnedOn - 1, H, M, result);
                    M[i] = false;
                }
            }
            
            for (int i = 0; i < H.Length; i++)
            {
                if (!H[i])
                {
                    H[i] = true;
                    Backtracking(turnedOn - 1, H, M, result);
                    H[i] = false;
                }
            }
        }
    }
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        List<string> result = new List<string>();
        bool[] H = new bool[4] {false, false, false, false};
        bool[] M = new bool[6] { false, false, false, false, false, false };

        Backtracking(turnedOn, H, M, result);
        
        return result;
    }
}