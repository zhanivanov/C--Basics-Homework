using System;

class ComparingFloats
{
    static void Main()
    {
        double precisionTest=0.000001;
        Console.WriteLine("Comparing floats");
        Console.WriteLine("Enter float numbers to be compared");
        Console.WriteLine("Enter A:");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter B:");
        double B = Convert.ToDouble(Console.ReadLine());
        bool equalAB = Math.Abs(A - B) < precisionTest;
        Console.WriteLine("Are the numbers equal? \n\n{0}",equalAB?"Yes":"No");
        Console.ReadKey();
    }
}
