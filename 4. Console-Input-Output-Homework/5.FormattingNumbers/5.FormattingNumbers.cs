using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer \"a\": ");
        int a = int.Parse(Console.ReadLine());
        string stringA=Convert.ToString(a,2);
        Console.Write("Enter b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c= ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0,-10:X2}|{1,10}|{2,10:0.00}|{3,-10:0.000}|",a,stringA.PadLeft(10,'0'),b,c);
    }
}