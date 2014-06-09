using System;

class CatalanNums
{
    static void Main()
    {
        Console.Write("Enter n(1<n<100)= ");
        int n = int.Parse(Console.ReadLine());
        double fact2N = 1;
        double factN = 1;
        double factNplus1 = 1;
        double factNcount = 1;
        double result;
        if (1<n&&n<100)
        {
            for (int i = 1; i <= 2*n; i++, factNcount++)
            {
                fact2N = fact2N * i;
                if (factNcount > n)
                {
                    continue;
                }
                factN = factN * i;
            }
            for (int i = 1; i <= (n+1); i++)
            {
                factNplus1 = factNplus1 * i;
            }
            result = (double)fact2N / (factNplus1 * factN);
            Console.WriteLine("The result is: {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}