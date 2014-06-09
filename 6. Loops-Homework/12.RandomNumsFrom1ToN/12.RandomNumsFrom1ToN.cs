using System;
using System.Collections.Generic;

class RandomNumsFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        List<int> forNums=new List<int>();
        Random randomGenerator = new Random();
        int randomIndx;
        for (int i = 1; i <= n; i++)
        {
            forNums.Add(i);
        }
        for (int i = 0; i < forNums.Count; i++)
        {
            randomIndx = randomGenerator.Next(0, forNums.Count);
            Console.Write("{0} ", forNums[randomIndx]);
        }
    }
}