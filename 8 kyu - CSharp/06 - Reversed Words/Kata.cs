using System;
using System.Linq;

public class Kata
{
    public static string ReverseWords(string str)
    {
        // Split the string into words, reverse the array, and join the reversed words with spaces:
        return string.Join(" ", str.Split(' ').Reverse());
    }
}