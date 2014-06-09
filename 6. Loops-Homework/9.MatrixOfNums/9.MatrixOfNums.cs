using System;

class MatrixOfNums
{
    static void Main()
    {
        Console.Write("Enter n(1<=n<=20)= ");
        int n = int.Parse(Console.ReadLine());
        int lineBeg = 0;
        int lineNums;
        if (1<=n&&n<=20)
        {
            for (int i = 0; i < n; i++)
            {
                lineBeg = lineBeg + 1;
                lineNums = lineBeg;
                for (int line = 0; line < n; line++,lineNums++)
                {
                    Console.Write(lineNums+" ");
                }
                Console.Write("\n");
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}