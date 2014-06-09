using System;

class PrintASCIITable
{
    static void Main(string[] args)
    {
        for (int c = 33; c < 127; c++)//only standart printable chars
        {
            Console.WriteLine("{0} = {1}",c,(char)c);
        }
    }
}
