using System;

class BitsExchange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        string UserIntString=Console.ReadLine();
        uint UserInt;
        bool result=UInt32.TryParse(UserIntString,out UserInt);
        if (result==false)
        {
            Console.WriteLine("Out of range!");
            Environment.Exit(0);
        }
        Console.WriteLine("Enter how many bits(k) you want to exchange: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position 'p' of the first bit you want to exchange: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position 'q' if the second bit you want to exchange: ");
        int q = int.Parse(Console.ReadLine());
        int ExchangedBit = q;
        int IfResult=0;
        int overlapCheck=0;
        int OutRangeCheck = 0;
        for (int AnotherExchangedBit = p; AnotherExchangedBit < p+k; AnotherExchangedBit++)
        {
            int mask = 1 << AnotherExchangedBit;
            uint OneExchangedBit = UserInt & (uint)mask;
            OneExchangedBit = OneExchangedBit >> AnotherExchangedBit;
            int anotherMask = 1 << ExchangedBit;
            uint TwoExchangedBit = UserInt & (uint)anotherMask;
            TwoExchangedBit = TwoExchangedBit >> ExchangedBit;
            if (OneExchangedBit==1)
            {
                UserInt = UserInt | (uint)anotherMask;
            }
            else
            {
                UserInt = UserInt & (uint)~anotherMask;
            }
            if (TwoExchangedBit==1)
            {
                UserInt = UserInt | (uint)mask;
            }
            else
            {
                UserInt = UserInt & (uint)~mask;
            }
            if (AnotherExchangedBit==q)
            {
                overlapCheck = 1;
                break;
            }
            if (q>p)
            {
                int OutOfRangeCheck = q + k;
                if (OutOfRangeCheck > 32)
                {
                    OutRangeCheck = 1;
                    break;
                }
            }
            else
            {
                int OutOfRangeCheck = p + k;
                if (OutOfRangeCheck > 32)
                {
                    OutRangeCheck = 1;
                    break;
                }
            }
            ExchangedBit++;
        }
        if (overlapCheck==1)
        {
            Console.WriteLine("Overlapping!");
        }
        else if(OutRangeCheck==1)
        {
            Console.WriteLine("Out of range!");
        }
        else
        {
            Console.WriteLine("The new integer is: {0}", UserInt);
        }
    }
}

