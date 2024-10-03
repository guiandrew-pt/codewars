using System;
using System.Collections.Generic;
using System.Text;  // For StringBuilder

public static class Kata
{
    public static string Capitalize(string s, List<int> idxs)
    {
        // Use StringBuilder for efficiency
        StringBuilder strResult = new StringBuilder(s);

        // Loop through the list of indices
        foreach (int index in idxs)
        {
            // Check if the index is within the bounds of the string
            if (index >= 0 && index < s.Length)
            {
                // Capitalize the character at the given index
                strResult[index] = char.ToUpper(s[index]);
            }
        }

        // Convert StringBuilder back to a string and return the result
        return strResult.ToString();
    }
}