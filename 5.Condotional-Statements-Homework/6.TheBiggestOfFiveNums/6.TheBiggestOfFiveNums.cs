using System;

class TheBiggestOfFiveNums
{
    static void Main()
    {
        Console.Write("Enter a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c= ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter d= ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter e= ");
        double e = double.Parse(Console.ReadLine());
        if (a>b&&a>c&&a>d&&a>e)
        {
            Console.WriteLine(a);
        }
        if (b>a&&b>c&&b>d&&b>e)
        {
            Console.WriteLine(b);
        }
        if (c>a&&c>b&&c>d&&c>e)
        {
            Console.WriteLine(c);
        }
        if (d>a&&d>b&&d>c&&d>e)
        {
            Console.WriteLine(d);
        }
        if (e>a&&e>b&&e>c&&e>d)
        {
            Console.WriteLine(e);
        }
    }
}