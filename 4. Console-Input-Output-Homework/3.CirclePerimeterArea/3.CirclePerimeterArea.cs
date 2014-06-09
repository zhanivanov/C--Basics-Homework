using System;

class CirclePerimeterArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter circle's radius: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("Area of the circle: {0:0.00}",area);
        Console.WriteLine("Perimeter of the circle: {0:0.00}",perimeter);
    }
}