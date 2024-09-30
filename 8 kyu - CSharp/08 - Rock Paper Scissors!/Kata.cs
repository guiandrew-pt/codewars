public class Kata
{
    public string Rps(string p1, string p2)
    {
        // Normalize inputs to lowercase to handle case-insensitivity
        p1 = p1.ToLower();
        p2 = p2.ToLower();

        // Draw condition
        if (p1 == p2)
        {
            return "Draw!";
        }

        // Player 1 win condition
        if ((p1 == "rock" && p2 == "scissors") ||
            (p1 == "scissors" && p2 == "paper") ||
            (p1 == "paper" && p2 == "rock"))
        {
            return "Player 1 won!";
        }

        // Player 2 win condition (default)
        return "Player 2 won!";
    }
}