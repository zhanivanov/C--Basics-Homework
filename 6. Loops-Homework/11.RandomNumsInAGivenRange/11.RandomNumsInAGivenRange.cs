using System;

class RandomNumsInAGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter the beginning of the interval:");
        Console.Write("min= ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the end of the interval:");
        Console.Write("max= ");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many nums from the interval to be printed:");
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        int printedNums;
        Random randomNumsGenerator = new Random();
        for (int i = 0; i < n; i++)
        {
            printedNums=randomNumsGenerator.Next(min, max);
            Console.Write("{0} ", printedNums);
        }
    }
}
