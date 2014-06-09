using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("Enter N= ");
        long n = long.Parse(Console.ReadLine());
        long zeroesCount = 0;
        long num;
        for (long i =1; i <= n; i++)
        {
            if (i%5==0)
            {
                num = i;
                while (num%5==0)
                {
                    num = num / 5;
                    zeroesCount++;
                }
            }
        }
        Console.WriteLine(zeroesCount);
    }
}