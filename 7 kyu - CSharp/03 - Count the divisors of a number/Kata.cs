public class Kata
{
    public static int Divisors(int n)
    {
        int result = 0;

        // Check divisors from 1 to sqrt(n)
        for (int i = 1; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                result++; // Count the divisor
                if (i != n / i)
                {
                    result++; // Count the complementary divisor
                }
            }
        }

        return result; // Return the count of divisors
    }
}