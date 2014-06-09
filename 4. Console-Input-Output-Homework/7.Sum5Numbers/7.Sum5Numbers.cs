using System;

class Sum5Numbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter five numbers: ");
        string input = Console.ReadLine();
        string[] nums = input.Split(new char[] { ' ' });
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += int.Parse(nums[i]);
        }
        Console.WriteLine("The sum of the entered numbers is: {0}",sum);
    }
}