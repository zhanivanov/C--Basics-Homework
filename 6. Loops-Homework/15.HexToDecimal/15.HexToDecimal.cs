using System;
using System.IO;

class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hex num: ");
        string hexNum = Console.ReadLine();
        char[] hexNumArr = new char[hexNum.Length];
        char[] hexSymbols = { '0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F' };
        StringReader hexNumString = new StringReader(hexNum);
        hexNumString.Read(hexNumArr, 0, hexNum.Length);
        int power = hexNumArr.Length-1;
        int decimalNum=0;
        for (int i = 0; i < hexNumArr.Length; i++)
        {
            for (int j = 0; j < hexSymbols.Length; j++)
            {
                if (hexNumArr[i]==hexSymbols[j])
                {
                    decimalNum = decimalNum + j * (int)Math.Pow(16, power);
                    power--;
                }
            }
        }
        Console.WriteLine("The converted num is: {0}", decimalNum);
    }
}