using System;

class PointInACircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 'x' and 'y' coordinates of the point you want to check: ");
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        int radius = 2;
        bool result = x * x + y * y <= radius * radius;
        Console.WriteLine(result? "The point is in the circle." : "The point is not in the circle");
    }
}
