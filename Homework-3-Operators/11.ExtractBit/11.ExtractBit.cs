using System;

class ExtractBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        uint UserInt = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint PreResult = UserInt & mask;
        uint Result = PreResult >> 3;
        Console.WriteLine("The third bit of the entered integer is: {0}",Result);
    }
}
