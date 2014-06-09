using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b= ");
        int b = int.Parse(Console.ReadLine());
        if (a>b)
        {
            Console.WriteLine("{0} {1}",b,a);
        }
        else
        {
            Console.WriteLine("{0} {1}",a,b);
        }
    }
}