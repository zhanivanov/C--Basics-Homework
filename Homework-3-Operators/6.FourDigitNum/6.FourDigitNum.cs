using System;

class FourDigitNum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a four digit number(abcd format): ");
        string abcd = Console.ReadLine();
        int number;
        bool result = Int32.TryParse(abcd,out number);
        if (result)
        {
            int a = number % 10;
            int b = (number / 10) % 10;
            int c = (number / 100) % 10;
            int d = (number / 1000) % 10;
            Console.WriteLine("The sum of the digits of the number is: {0}",a+b+c+d);
            Console.WriteLine("The reverse of the num you entered is: {0}{1}{2}{3}",a,b,c,d);
            Console.WriteLine("Put the last digit of the number in the first place: {0}{1}{2}{3}",a,d,c,b);
            Console.WriteLine("Exchange the second and the third digit: {0}{1}{2}{3}",d,b,c,a);
        }
        else
        {
            Console.WriteLine("You entered wrong number");
        }
    }
}