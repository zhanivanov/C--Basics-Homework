using System;

class CalculateCombinations
{
    static void Main()
    {
        Console.Write("Enter number of the elements you want to choose out of a group(1<k<n<100):\nK= ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Enter how many elements are there in the group:\nN= ");
        int N = int.Parse(Console.ReadLine());
        double factK = 1;
        double factN = 1;
        double factNminusK = 1;
        double factKcount=1;
        double result;
        if (1<K&&K<N&&N<100)
        {
            for (int i = 1; i <= N; i++,factKcount++)
            {
                factN = factN * i;
                if (factKcount>K)
                {
                    continue;
                }
                factK = factK * i;
            }
            for (int i = 1; i <= (N-K); i++)
            {
                factNminusK = factNminusK * i;
            }
            result = (double)factN / (factK * factNminusK);
            Console.WriteLine("The result is: {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}