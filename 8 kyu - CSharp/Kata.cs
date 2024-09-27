public static class Kata
{
    public static string bonus_time(int salary, bool bonus)
    {
        // Initialize the result with the salary
        int result = salary;

        // If bonus is true, multiply the salary by 10
        if (bonus)
        {
            result *= 10;
        }

        // Return the formatted string with the dollar sign
        return $"${result}";
    }
}