public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        // Initialize final points to 0
        int final_points = 0;

        // Loop through each game in the array
        for (int i = 0; i < games.Length; i++)
        {
            // Split the score "x:y" into two parts
            string[] score = games[i].Split(':');
            int x = int.Parse(score[0]); // our score
            int y = int.Parse(score[1]); // opponent's score

            // Determine the result of the game
            if (x > y)
            {
                final_points += 3; // Win
            }
            else if (x == y)
            {
                final_points += 1; // Tie
            }
            // No need for an else for losses, since no points are added
        }

        // Return the total points
        return final_points;
    }
}