public class Solution
{
    public bool IsPalindrome(int x)
    {
        int mirrored = 0; int x_copy = x;
        if (x < 0)
            return false;

        while (x_copy > 0)
        {
            mirrored = mirrored * 10 + x_copy % 10;
            x_copy = x_copy / 10;
        }

        if (mirrored == x)
            return true;

        return false;
    }
}