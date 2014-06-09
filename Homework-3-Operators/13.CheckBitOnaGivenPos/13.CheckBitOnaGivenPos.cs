using System;

class CheckBitOnaGivenPos
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        int UserInt = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit you want to check: ");
        int BitPos = int.Parse(Console.ReadLine());
        int mask = 1 << BitPos;
        int PreResult = UserInt & mask;
        int result = PreResult >> BitPos;
        if (result==1)
        {
            Console.WriteLine("TRUE!");
        }
        else
        {
            Console.WriteLine("FALSE!");
        }
    }
}
