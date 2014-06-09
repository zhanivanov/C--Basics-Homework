using System;

class StringAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object HelloWorld = hello +" "+ world;
        string FinalString = (string)HelloWorld;
        Console.WriteLine(FinalString);
    }
}
