using System;
using System.IO;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string decNum = Console.ReadLine();
        int decNumInt = int.Parse(decNum);
        int remainder=decNumInt;
        int result;
        int power=decNum.Length-1;
        for (int i = decNum.Length-1; i >= 0; i--,power--)
        {
            decNumInt = remainder / (int)Math.Pow(16, power);
            remainder =remainder%(int)Math.Pow(16,power);
            if (decNumInt>=1&&decNumInt<10)
            {
                Console.Write(decNumInt);
            }
            else
            {
                switch (decNumInt)
                {
                    case 10:
                        Console.Write("A");
                        break;
                    case 11:
                        Console.Write("B");
                        break;
                    case 12:
                        Console.Write("C");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("E");
                        break;
                    case 15:
                        Console.Write("F");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
