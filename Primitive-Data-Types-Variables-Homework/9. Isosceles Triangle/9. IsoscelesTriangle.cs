using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int CharsPerLine=1;
        int AllLines = 3;
        int spaces = AllLines-1;
        char symbol = '\x00A9';
        for (int i = 0; i < AllLines; i++)
        {
            for (int j = spaces; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < CharsPerLine; k++)
            {
                Console.Write(symbol);
                if (k==CharsPerLine-1)
                {
                    Console.WriteLine();
                }
            }
            CharsPerLine = CharsPerLine + 2;
            spaces = spaces - 1;
        }
    }
}