using System;

class TheBiggestOf3Nums
{
    static void Main()
    {
        Console.Write("Enter a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c= ");
        double c = double.Parse(Console.ReadLine());
        if (a>c&&a>b)
        {
            Console.WriteLine(a);
        }
        else if (b>a&&b>c)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b)
        {
            Console.WriteLine(c);
        }
    }
}