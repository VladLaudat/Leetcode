public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int low=0, high = (matrix.Length * matrix[0].Length)-1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int row = (mid - 1) / matrix[0].Length; if(row<0) row = 0;
            int col = (mid - 1) % matrix[0].Length; if (col<0) col = 0;

            if (matrix[row][col] == target) return true;
            else if (matrix[row][col] > target)
            {
                high = mid-1;
            }
            else
            {
                low = mid+1;
            }
        }
        
        return false;
    }
}