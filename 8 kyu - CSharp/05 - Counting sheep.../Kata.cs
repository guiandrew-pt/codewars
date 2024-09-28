using System;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        // Initialize the counter to hold the number of sheep present
        int num_sheeps = 0;

        // Check if the array is null (invalid input), if so return 0
        if (sheeps == null)
        {
            return 0;
        }

        // Loop through each element in the array
        foreach (bool sheep in sheeps)
        {
            // If the current sheep is present (true), increment the counter
            if (sheep)
            {
                num_sheeps++;
            }
        }

        // Return the total number of sheep present
        return num_sheeps;
    }
}

// LINQ version:
using System;
using System.Linq;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        // Use LINQ to count how many `true` values are in the array
        // If `sheeps` is null, the `?.` (null-conditional operator) prevents calling `Count()`
        // The `?? 0` ensures we return 0 in case the array is null
        return sheeps?.Count(sheep => sheep) ?? 0;
    }
}