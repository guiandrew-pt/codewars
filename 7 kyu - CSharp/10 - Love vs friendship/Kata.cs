using System;

public static class Kata
{
    public static int WordsToMarks(string str)
    {
        int result = 0;

        for (int i = 0; i < str.Length; i++)
        {
            result += (str[i] - 'a' + 1);  // Directly calculate the position in the alphabet
        }

        return result;
    }
}
