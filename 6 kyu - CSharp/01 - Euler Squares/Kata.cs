using System;
using System.Collections.Generic;

public class EulerSquare
{
    public static int[][,] CreateEulerSquare(int n)
    {
        int[,] square1 = new int[n, n];  // First Latin Square
        int[,] square2 = new int[n, n];  // Second Latin Square

        // Create the first Latin square with cyclic shifting
        for (int i = 0; i < n; i++)  // Rows
        {
            for (int j = 0; j < n; j++)  // Columns
            {
                // First square: Cyclic shift
                square1[i, j] = (i + j) % n + 1;  // Cyclic pattern: shift by row index

                // Second square: Another cyclic shift (different pattern)
                square2[i, j] = (i + 2 * j) % n + 1;  // Different shift pattern
            }
        }

        // Check orthogonality
        HashSet<string> pairs = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Create a unique string pair from both squares
                string pair = square1[i, j] + "," + square2[i, j];

                // Check if the pair already exists in the set
                if (pairs.Contains(pair))
                {
                    throw new Exception("The squares are not orthogonal!");
                }
                else
                {
                    pairs.Add(pair);  // Add the pair to the set
                }
            }
        }

        return new int[][,] { square1, square2 }; // Return both squares if they are orthogonal
    }
}
