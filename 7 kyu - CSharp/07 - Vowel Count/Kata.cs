using System;
using System.Collections.Generic;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        // Define a HashSet of vowels for fast lookup
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        int vowelCount = 0;

        // Loop through each character in the string
        foreach (char c in str)
        {
            // Increment count if the character is a vowel
            if (vowels.Contains(c))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
}
