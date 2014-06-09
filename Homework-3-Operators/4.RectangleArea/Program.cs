using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the side 'a' of the rectangle: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the side 'b' of the rectangle: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the rectangle is: {0}",2*(a+b));
        Console.WriteLine("The area of the rectangle is: {0}",a*b);
    }
}
