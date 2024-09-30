public class Number
{
    public bool IsEven(double n)
    {
        // Check if it's a whole number and even
        if (n % 1 == 0 && n % 2 == 0)
        {
            return true;
        }

        // Otherwise, return false
        return false;
    }
}