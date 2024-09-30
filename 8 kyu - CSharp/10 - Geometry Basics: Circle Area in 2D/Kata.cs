using System;

public static class Kata
{
    public static double CircleArea(Circle circle)
    {
        // Formula for the area of a circle: π * radius^2
        double area = Math.PI * Math.Pow(circle.Radius, 2);

        return area;
    }
}
