using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int TempInt;
        TempInt = a;
        a = b;
        b = TempInt;
        Console.WriteLine("a= {0}\nb= {1}",a,b);
    }
}
