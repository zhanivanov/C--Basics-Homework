using System;

class ExtractGivenBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        int UserInt = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit you want to extract: ");
        int BitPos = int.Parse(Console.ReadLine());
        int mask = 1 << BitPos;
        int preResult = UserInt & mask;
        int result = preResult >> BitPos;
        Console.WriteLine("The bit on positon \"{0}\" is: \"{1}\"",BitPos,result);
    }
}
