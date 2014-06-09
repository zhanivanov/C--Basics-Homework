using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b= ");
        int b = int.Parse(Console.ReadLine());
        int gcd = 0;
        int temp;
        int remainder;
        while(b!=0)
        {
            temp = b;
            b = a % b;
            a = temp;
        }
        gcd = a;
        Console.WriteLine(gcd);
    }
}