using System;

class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers:");
        string input = Console.ReadLine();
        string[] nums=input.Split(new char[] {' '});
        int oddProduct=1;
        int evenProuct=1;
        int pointer = 0;
        for (int i = 1; i <=nums.Length; i++,pointer++)
        {
            if (i%2==0)
            {
                evenProuct = evenProuct * int.Parse(nums[pointer]);
            }
            else
            {
                oddProduct = oddProduct * int.Parse(nums[pointer]);
            }
        }
        if (oddProduct==evenProuct)
        {
            Console.WriteLine("YES!");
            Console.WriteLine("product= {0}",evenProuct);
        }
        else
        {
            Console.WriteLine("NO!");
            Console.WriteLine("Odd product= {0}",oddProduct);
            Console.WriteLine("Even product= {0}",evenProuct);
        }
    }
}