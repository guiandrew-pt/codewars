using System;

public class Kata
{
    public static double DistanceBetweenPoints(Point a, Point b)
    {
        // Calculate the difference in X and Y coordinates
        double deltaX = b.X - a.X;
        double deltaY = b.Y - a.Y;

        // Distance formula: sqrt((x2 - x1)^2 + (y2 - y1)^2)
        return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
    }
}
