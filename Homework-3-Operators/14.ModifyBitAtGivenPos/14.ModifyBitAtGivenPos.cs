using System;

class ModifyBitAtGivenPos
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        int UserInt = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit you want to modify: ");
        int BitPos = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value(0 or 1) you want to put in the position you just entered: ");
        int value = int.Parse(Console.ReadLine());
        if (value==1)
        {
            int mask = 1 << BitPos;
            int result = UserInt | mask;
            Console.WriteLine("The new integer is: {0}",result);
        }
        else
        {
            int mask = 1 << BitPos;
            int result = UserInt & ~mask;
            Console.WriteLine("The new integer is: {0}",result);
        }
    }
}
