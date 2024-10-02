namespace myjinxin
{
    using System;

    public class Kata
    {
        public int[] TableGame(int[][] table)
        {
            // Define the variables a, b, c, d as per the explanation
            int a = table[0][0];                   // a1 = a
            int b = table[0][2];                   // a3 = b
            int c = table[2][0];                   // c1 = c
            int d = table[2][2];                   // c3 = d

            // Now we can compute and check if these values are valid
            if (a + b != table[0][1]) return new int[] { -1 };            // a2 = a + b
            if (a + c != table[1][0]) return new int[] { -1 };            // b1 = a + c
            if (b + d != table[1][2]) return new int[] { -1 };            // b3 = b + d
            if (a + b + c + d != table[1][1]) return new int[] { -1 };    // b2 = a + b + c + d

            // If all conditions are satisfied, return the counts
            return new int[] { a, b, c, d };
        }
    }
}