﻿using System;

class SortThreeNums
{
    static void Main()
    {
        Console.Write("Enter a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c= ");
        double c = double.Parse(Console.ReadLine());
        if (a>b&&a>c)
        {
            if (b>c)
            {
                Console.WriteLine("{0} {1} {2}",a,b,c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}",a,c,b);
            }
        }
        else if(b>a&&b>c)
        {
            if (a>c)
            {
                Console.WriteLine("{0} {1} {2}",b,a,c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        else
        {
            if (a>b)
            {
                Console.WriteLine("{0} {1} {2}",c,a,b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}
