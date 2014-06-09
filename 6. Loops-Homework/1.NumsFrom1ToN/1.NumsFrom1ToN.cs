using System;

class NumsFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter an integer:");
        int userInt = int.Parse(Console.ReadLine());
        for (int i = 1; i < userInt+1; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}