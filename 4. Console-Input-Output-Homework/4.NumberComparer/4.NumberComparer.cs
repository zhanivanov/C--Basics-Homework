using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        bool result = a > b;
        Console.WriteLine(result? a:b);
    }
}
