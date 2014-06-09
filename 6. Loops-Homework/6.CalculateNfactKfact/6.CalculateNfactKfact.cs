using System;

class CalculateNfactKfact
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k(1<k<n<100)= ");
        int k = int.Parse(Console.ReadLine());
        int factN = 1;
        int factK = 1;
        int p=1;
        double result;
        if (1<k&&k<n&&n<100)
        {
            for (int i = 1; i <= n; i++,p++)
            {
                factN = factN * i;
                if (p>k)
                {
                    continue;
                }
                factK = factK * p;
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
        result = (double)factN / factK;
        Console.WriteLine("N!/K!= {0}",result);
    }
}