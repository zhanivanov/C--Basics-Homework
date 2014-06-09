using System;

class EmployeeData
{
    static void Main(string[] args)
    {
        string FirstName = "George";
        string LastName = "Clooney";
        byte age = 36;
        char gender = 'm';
        long IDNum = 8306112507;
        int EmployeeNum = 27560058;
        Console.WriteLine("Name: {0}",FirstName+" "+LastName);
        Console.WriteLine("Age: {0}",age);
        Console.WriteLine("Gender: {0}",gender);
        Console.WriteLine("ID Number: {0}",IDNum);
        Console.WriteLine("Employee unique number: {0}",EmployeeNum);
    }
}

