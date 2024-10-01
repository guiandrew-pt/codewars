public class LatinSquare
{
    public static int[][] MakeLatinSquare(int n)
    {
        // Create an n x n 2D array
        int[][] latinSquare = new int[n][];

        // Fill the array with the Latin square pattern
        for (int i = 0; i < n; i++)
        {
            latinSquare[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                // Cyclic shift: start with 1, then shift by row index
                latinSquare[i][j] = (i + j) % n + 1;
            }
        }

        return latinSquare;
    }
}