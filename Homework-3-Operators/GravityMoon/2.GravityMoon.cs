using System;

class GravityMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your weight: ");
        float UserWeight = float.Parse(Console.ReadLine());
        UserWeight =(float)17 / 100 * UserWeight;
        Console.WriteLine("Your weight on the moon will be: {0} kg",UserWeight);
    }
}
