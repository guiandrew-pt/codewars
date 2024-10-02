using System;
using System.Collections.Generic;

public class NoOddities
{
    public static int[] NoOdds(int[] values)
    {
        List<int> evenNumbers = new List<int>();

        // Iterate through the array
        for (int i = 0; i < values.Length; i++)
        {
            // Check if the number is even
            if (values[i] % 2 == 0)
            {
                evenNumbers.Add(values[i]);
            }
        }

        // Convert the list of even numbers back to an array
        return evenNumbers.ToArray();
    }
}