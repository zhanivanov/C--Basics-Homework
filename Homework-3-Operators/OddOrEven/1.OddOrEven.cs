using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer: ");
        int UserInt = int.Parse(Console.ReadLine());
        if (UserInt%2==0)
        {
            Console.WriteLine("The number is EVEN");
        }
        else
        {
            Console.WriteLine("The number is ODD");
        }
    }
}
