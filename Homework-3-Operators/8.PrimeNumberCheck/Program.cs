using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        int UserInt = int.Parse(Console.ReadLine());
        for (int i = 1; i < UserInt+1; i++)
        {
            if (UserInt%i==0)
            {
                if (i==UserInt)
                {
                    Console.WriteLine("The entered integer is prime");
                }
                else if (i==1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("The entered integer is not prime");
                    break;
                }
            }
        }
    }
}