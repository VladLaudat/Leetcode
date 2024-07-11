public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int i = sr, j = sc; int defColor = image[i][j];
        if (color == image[i][j])
            return image;
        if (i >= 0 && i < image.Length && j >= 0 && j < image[0].Length)
        {
            image[i][j] = color;

            if (i > 0)
                if (image[i - 1][j] == defColor)
                    FloodFill(image, i - 1, j, color);

            if (i < image.Length - 1)
                if (image[i + 1][j] == defColor)
                    FloodFill(image, i + 1, j, color);

            if (j > 0)
                if (image[i][j - 1] == defColor)
                    FloodFill(image, i, j - 1, color);

            if (j < image[0].Length - 1)
                if (image[i][j + 1] == defColor)
                    FloodFill(image, i, j + 1, color);


        }
        return image;
    }
}