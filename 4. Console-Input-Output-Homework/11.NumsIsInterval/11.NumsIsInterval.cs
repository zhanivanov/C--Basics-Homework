using System;
using System.Collections.Generic;

class NumsIsInterval
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an interval:");
        Console.Write("Beginning= ");
        int beg = int.Parse(Console.ReadLine());
        Console.Write("End= ");
        int end = int.Parse(Console.ReadLine());
        List<int> nums = new List<int> { };
        int p = 0;
        for (int i = beg,n=0; i <= end; i++,n++)
        {
            if (i % 5 == 0)
            {
                nums.Add(i);
                p++;
            }
            else continue;
        }
        Console.WriteLine("p= {0}",p);
        foreach (var item in nums)
        {
            Console.Write(item.ToString() + ", ");
        }
    }
}