using System;

class Print10YearsLaterDate
{
    static void Main()
    {
        int yourage;
        Console.WriteLine("How old are you going to be ten years from now?\n");
        Console.WriteLine("Enter your age: ");
        yourage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n10 years from now you're going to be {0} years old.",yourage+10);
        
    }
}
