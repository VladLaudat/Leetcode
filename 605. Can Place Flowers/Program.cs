public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if(n>flowerbed.Length) return false;

        if(flowerbed.Length==1)
            if (flowerbed[0]==0)
                return true;

        int i = 0;
        while(i<flowerbed.Length)
        {
            if (flowerbed[i] == 0)
            {
                if (i == 0)
                {
                    if (flowerbed[i + 1] == 0)
                       { n--; flowerbed[i] = 1; }
                }
                else
            if (i == flowerbed.Length - 1)
                {
                    if (flowerbed[i - 1] == 0)
                    { n--; flowerbed[i] = 1; }
                }
                else
            if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                { n--; flowerbed[i] = 1; }
            }
            i++;
        }

        return n > 0 ? false : true;
    }
}