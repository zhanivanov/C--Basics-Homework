using System;

class FibonacciSequene
{
    static void Main()
    {
        Console.Write("Enter how many numbers from the sequence to be printed: ");
        int n = int.Parse(Console.ReadLine());
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal sum = 0;
        Console.Write("{0} ",firstNumber);
        Console.Write("{0} ",secondNumber);
        for (int i = 0; i < n-2; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            Console.Write("{0} ",sum);

        }

    }
}