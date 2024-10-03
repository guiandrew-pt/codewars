// input is a string of three chars from the set
// 'D', 'F', 'I', 'K'; output is a single char from this set
using System;
using System.Linq; // To use LINQ methods like Count()

public static class Kata
{
    public static char TrilingualDemocracy(string group)
    {
        // Rule 1: If all three are the same language
        if (group[0] == group[1] && group[1] == group[2])
        {
            return group[0]; // Return the common language
        }

        // Rule 2: Two speak the same language, one speaks a different one
        // Use LINQ to count occurrences of each language
        // Use LINQ to count occurrences of each language and return the minority language (the one that appears once)
        if (group.Count(c => c == 'D') == 2) return group.First(c => c != 'D');
        if (group.Count(c => c == 'F') == 2) return group.First(c => c != 'F');
        if (group.Count(c => c == 'I') == 2) return group.First(c => c != 'I');
        if (group.Count(c => c == 'K') == 2) return group.First(c => c != 'K');

        // Rule 3: All three speak different languages
        // The missing language is the one that should be used
        char[] allLanguages = { 'D', 'F', 'I', 'K' };
        return allLanguages.First(lang => !group.Contains(lang));
    }
}
