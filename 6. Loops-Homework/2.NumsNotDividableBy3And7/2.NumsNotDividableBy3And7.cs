using System;

class NumsNotDividableBy3And7
{
    static void Main()
    {
        Console.Write("Enter an integer:");
        int userInt = int.Parse(Console.ReadLine());
        for (int i = 1; i < userInt+1; i++)
        {
            if (i%3==0||i%7==0)
            {
                continue;
            }
            else
            {
                Console.Write("{0} ", i);
            }
        }
    }
}