public static class Kata
{
    public static string AbbrevName(string name)
    {
        // Split the name into two words
        string[] words = name.Split(' ');

        // Get the first character of each word and convert to uppercase
        string firstCharacter = words[0].Substring(0, 1).ToUpper();
        string secondCharacter = words[1].Substring(0, 1).ToUpper();

        // Return the initials with a dot in between
        return $"{firstCharacter}.{secondCharacter}";
    }
}