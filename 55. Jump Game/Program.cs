using System.ComponentModel;

public class Solution
{
    public bool CanJump(int[] nums)
    {
        int i = 0;
        foreach(int n in nums)
        {
            if (i < 0) return false;
            else
                if (n > i)
                i = n;
            i--;
        }
        return true;
    }
}