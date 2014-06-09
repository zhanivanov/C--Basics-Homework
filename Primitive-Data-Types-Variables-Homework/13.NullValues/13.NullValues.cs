using System;

class NullValues
{
    static void Main(string[] args)
    {
        int? NullInt = null;
        Console.WriteLine(NullInt); //prints nothing
        double? NullDouble = null;
        Console.WriteLine(NullDouble); //prints nothing
        NullInt = 3;
        NullDouble = 0;
        Console.WriteLine("NullInt: {0}\nNullDouble: {1}",NullInt,NullDouble);
    }
}