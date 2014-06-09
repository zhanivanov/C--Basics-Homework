using System;

class InCircleOutRectangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the \"x\" and \"y\" coordinates of your point: ");
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        float radius=1.5F;
        int CenterX=1;
        int CenterY=1;
        bool result = ((x - CenterX) * (x - CenterX) + (y - CenterY) * (y - CenterY) <= radius * radius && x >= -1 && x <= 5 && y >= 1 && y <= 3);
        Console.WriteLine("Inside the circle & outside of the rectangle: {0}",result?"YES":"NO");
    }
}
