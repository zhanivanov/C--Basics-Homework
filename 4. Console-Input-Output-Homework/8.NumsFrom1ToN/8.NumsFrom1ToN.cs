using System;

class NumsFrom1ToN
{
    static void Main(string[] args)
    {
        Console.Write("enter num n= ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n + 1; i++)
        {
            Console.WriteLine(i);
        }
    }
}
