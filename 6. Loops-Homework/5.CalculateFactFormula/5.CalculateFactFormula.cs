using System;

class CalculateFactFormula
{
    static void Main()
    {
        Console.Write("Enter the int n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the int x=");
        int x = int.Parse(Console.ReadLine());
        double S=0;
        double fact=1;
        double power=1;
        for (int i = 1; i <= n; i++)
        {
            fact=fact*i;
            power = power * x;
            S += (fact / power);
        }
        Console.WriteLine("The Sum of sequence of these numbers N and X is S={0:F5}",S+1);
    }
}
