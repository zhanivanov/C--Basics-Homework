using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter card sign: ");
        string cardSign = Console.ReadLine();
        int cardNumber;
        char cardChar;
        if (int.TryParse(cardSign,out cardNumber))
        {
            if (cardNumber >= 2 && cardNumber <= 10)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else if (char.TryParse(cardSign,out cardChar))
        {
            if (cardChar=='j'||cardChar=='q'||cardChar=='k'||cardChar=='a')
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
