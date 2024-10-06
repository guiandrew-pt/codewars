public class Kata
{
    public static string Stringify(Node list)
    {
        if (list == null)
        {
            return "null"; // Handle the case where the list is empty
        }

        Node current = list;
        string result = "";

        while (current != null)
        {
            result += current.Data + " -> "; // Append the data followed by " -> "
            current = current.Next; // Move to the next node
        }

        result += "null"; // Append "null" at the end

        return result;
    }
}
