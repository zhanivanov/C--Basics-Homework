using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the coefficents of the equation");
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c= ");
        int c = int.Parse(Console.ReadLine());
        double x1,x2,D;
        if (a==0)
        {
            if (b==0)
            {
                if (c==0)
                {
                    Console.WriteLine("Every \"x\" is solution.");
                }
                else
                {
                    Console.WriteLine("There is no solution.");
                }
            }
            else
            {
                x1 = (double)-c / b;
                Console.WriteLine("One root x= {0:0.000}",x1);
            }
        }
        else
        {
            D = (b * b - 4 * a * c);
            if (D<0)
            {
                Console.WriteLine("There are no real roots.");
            }
            else if (D==0)
            {
                x1 = x2 = -(b / (2 * a));
                Console.WriteLine("Double root x1=x2= {0}",x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Root x1= {0}",x1);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Root x2= {0}",x2);
            }
        }
    }
}