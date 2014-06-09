using System;

class MinMaxAverageOfNums
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of integers:");
        Console.WriteLine("To end the sequence press any key different from num");
        int userInt;
        int flag = 0;
        int min=0;
        int max=0;
        int counter = 0;
        int sum = 0;
        double average;
        bool result;
        while (true)
        {
            result = Int32.TryParse(Console.ReadLine(), out userInt);
            if (result)
            {
                if (flag == 1)
                {
                    if (max < userInt)
                    {
                        max = userInt;
                    }
                    if (min > userInt)
                    {
                        min = userInt;
                    }
                    sum = sum + userInt;
                    counter++;
                }
                if (flag == 0)
                {
                    min = userInt;
                    max = userInt;
                    sum = sum + userInt;
                    counter++;
                    flag = 1;
                }
            }
            else
            {
                break;
            }
        }
        average = (double)sum / counter;
        Console.WriteLine("min = {0}",min);
        Console.WriteLine("max = {0}",max);
        Console.WriteLine("sum = {0}",sum);
        Console.WriteLine("avg = {0}",average);
    }
}
