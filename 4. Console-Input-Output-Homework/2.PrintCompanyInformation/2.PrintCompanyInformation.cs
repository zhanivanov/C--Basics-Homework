using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the company's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter the adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager's frist name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager's last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        string age = Console.ReadLine();
        Console.Write("Enter manager's phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Company name: {0}\nCompany adress: {1}\nCompany phone: {2}\nFax number: {3}\nWeb site: {4}",companyName,companyAdress,companyPhone,faxNumber,webSite);
        Console.WriteLine("Manager: {0}\nAge: {1}\nPhone: {2}",(firstName+" "+lastName),age,managerPhone);
    }
}