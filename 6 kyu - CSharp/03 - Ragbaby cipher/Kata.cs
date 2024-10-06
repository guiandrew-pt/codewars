using System;
using System.Collections.Generic;

public class Kata
{
    // Encode function
    public static string Encode(string text, string key)
    {
        return Cipher(text, key, true); // Call helper function with 'true' for encoding
    }

    // Decode function
    public static string Decode(string text, string key)
    {
        return Cipher(text, key, false); // Call helper function with 'false' for decoding
    }

    // Helper function to build the keyed alphabet
    private static string BuildKeyedAlphabet(string key)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        HashSet<char> used = new HashSet<char>();
        string keyedAlphabet = "";

        // Add the key's characters first (ignoring duplicates)
        foreach (char c in key)
        {
            if (!used.Contains(c))
            {
                keyedAlphabet += c;
                used.Add(c);
            }
        }

        // Add the rest of the alphabet
        foreach (char c in alphabet)
        {
            if (!used.Contains(c))
            {
                keyedAlphabet += c;
            }
        }

        return keyedAlphabet;
    }

    // Helper function for encoding and decoding
    private static string Cipher(string text, string key, bool encode)
    {
        string keyedAlphabet = BuildKeyedAlphabet(key);  // Build the keyed alphabet
        string result = "";

        int wordPosition = 1; // Track the position of letters in the current word

        for (int i = 0; i < text.Length; i++)
        {
            char textChar = text[i];    // Current character in the text

            // If the character is not a letter, reset word position after space and continue
            if (!char.IsLetter(textChar))
            {
                result += textChar;
                wordPosition = 1; // Reset position for the next word after spaces or punctuation
                continue;
            }

            // Determine if the character is uppercase or lowercase
            bool isUppercase = char.IsUpper(textChar);

            // Normalize the text character to lowercase for shifting
            char normalizedTextChar = char.ToLower(textChar);

            // Get the current position of the letter in the **keyed alphabet**
            int originalPosition = keyedAlphabet.IndexOf(normalizedTextChar);

            // Shift based on the wordPosition (1-based) in the keyed alphabet
            int newPosition;

            if (encode)
            {
                // For encoding, shift forward based on word position
                newPosition = (originalPosition + wordPosition) % 26;
            }
            else
            {
                // For decoding, shift backward based on word position
                newPosition = (originalPosition - wordPosition + 26) % 26;
            }

            // Find the encoded/decoded character from the **keyed alphabet**
            char newChar = keyedAlphabet[newPosition];

            // If the original character was uppercase, convert the result to uppercase
            if (isUppercase)
            {
                newChar = char.ToUpper(newChar);
            }

            result += newChar; // Add the new character to the result

            wordPosition++; // Increment the position in the word
        }

        return result; // Return the encoded/decoded string
    }
}