using System;

class Sum3Int
{
    static void Main(string[] args)
    {
        Console.Write("Enter a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b= ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c= ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of {0},{1} and {2} is {3}",a,b,c,a+b+c);
    }
}