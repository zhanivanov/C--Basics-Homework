using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1--> int\n2--> double\n3--> string");
        string input = Console.ReadLine();
        int choice;
        if (int.TryParse(input,out choice))
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an integer: ");
                    int userInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(userInt+1);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double userDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(userDouble+1);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string userString = Console.ReadLine();
                    Console.WriteLine(userString+"*");
                    break;
                default:
                    Console.WriteLine("Wrong input!!!\nPress [enter] to exit...");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
