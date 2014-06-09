using System;

class DivideBy7and5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        int UserInt = int.Parse(Console.ReadLine());
        if (UserInt%7==0)
        {
            if (UserInt%5==0)
            {
                Console.WriteLine("The number is dividable by 5 and 7 at the same time");
            }
            else
            {
                Console.WriteLine("The number is not dividable without residue by 5 and 7 at the same time");
            }
        }
        else
        {
            Console.WriteLine("The number is not dividable without residue by 5 and 7 at the same time");
        }
    }
}
