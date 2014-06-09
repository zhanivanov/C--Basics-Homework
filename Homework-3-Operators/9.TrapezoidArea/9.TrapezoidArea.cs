using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter side \"a\": ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter side \"b\": ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height \"h\": ");
        float h = float.Parse(Console.ReadLine());
        Console.WriteLine(@"The area of your figure is: ""{0}""",(float)((a+b)/2)*h);
    }
}