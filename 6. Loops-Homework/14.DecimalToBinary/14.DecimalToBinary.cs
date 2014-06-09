using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal num which you want to convert to binary: ");
        long decimalNum = long.Parse(Console.ReadLine());
        List<int> binValues=new List<int>();
        string outputNum;
        while(decimalNum!=0)
        {
            binValues.Add((int)decimalNum%2);
            decimalNum = (int)decimalNum / 2;
        }
        for (int i = binValues.Count-1; i >=0; i--)
        {
            Console.Write(binValues[i]);
        }
    }
}