using System;

class QuotesInStrings
{
    static void Main()
    {
        string quotes=@"The ""use"" of quotations causes difficulties";
        string NoQuotes="The \"use\" of quotations causes difficulties";
        Console.WriteLine(quotes);
        Console.WriteLine(NoQuotes);
    }
}
