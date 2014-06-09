using System;

class SumOfNNums
{
    static void Main(string[] args)
    {
        Console.Write("Enter how many numbers you want to sum: ");
        int input = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter n= ");
            double n = double.Parse(Console.ReadLine());
            sum += n;
        }
        Console.WriteLine("The sum of the entered numbers is: {0}",sum);
    }
}
