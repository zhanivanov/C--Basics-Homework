using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score(0-9): ");
        int score=int.Parse(Console.ReadLine());
        if (score>0&&score<=9)
        {
            if (score>=1&&score<=3)
            {
                Console.WriteLine(score*10);
            }
            else if (score>=4&&score<=6)
            {
                Console.WriteLine(score*100);
            }
            else
            {
                Console.WriteLine(score*1000);
            }
        }
        else
        {
            Console.WriteLine("Invalid score!");
        }
    }
}