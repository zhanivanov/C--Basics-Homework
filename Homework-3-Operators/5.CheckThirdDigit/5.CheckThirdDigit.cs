using System;

class CheckThirdDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        int UserInt = int.Parse(Console.ReadLine());
        if ((UserInt/100)%10==7)
        {
            Console.WriteLine("TRUE!\nThe third digit(right-to-left) of the number is '7'");
        }
        else
        {
            Console.WriteLine("False!");
        }
    }
}
