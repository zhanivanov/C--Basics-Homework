using System;
class NumsAsWords
{
    static void Main()
    {
        Console.Write("Enter a num between the interval [0,999]: ");
        int userNum = int.Parse(Console.ReadLine());
        int state = 0;
        int decimals;
        int flag = 0;
        int exit = 0;
        if (userNum >= 0)
        {
            state = 1;
        }
        if ((userNum / 10) >= 1)
        {
            state = 2;
        }
        if ((userNum / 100) >= 1)
        {
            state = 3;
        }
        do
        {
            switch (state)
            {
            case 1:
                switch (userNum%10)
	            {
                    case 0:
                        if (flag==2)
                        {
                            Console.Write("twenty");
                            exit = 1;
                            break;
                        }
                        Console.WriteLine("zero");
                        exit = 1;
                        break;
                    case 1:
                        if(flag==2)
                        {
                            Console.Write("twenty ");
                        }
                        Console.WriteLine("one");
                        exit = 1;
                        break;
                    case 2:
                        if (flag == 2)
                        {
                            Console.Write("twenty ");
                        }
                        Console.WriteLine("two");
                        exit = 1;
                        break;
                    case 3:
                        if (flag == 2)
                        {
                            Console.Write("twenty ");
                        }
                        Console.WriteLine("three");
                        exit = 1;
                        break;
                    case 4:
                        if (flag == 2)
                        {
                            Console.Write("twenty ");
                        }
                        Console.WriteLine("four");
                        exit = 1;
                        break;
                    case 5:
                        if (flag == 2)
                        {
                            Console.Write("twenty ");
                        }
                        Console.WriteLine("five");
                        exit = 1;
                        break;
                    case 6:
                        if (flag == 2)
                        {
                            Console.Write("twenty ");
                        }
                        Console.WriteLine("six");
                        exit = 1;
                        break;
                    case 7:
                        if (flag == 2)
                        {
                            Console.Write("twenty ");
                        }
                        Console.WriteLine("seven");
                        exit = 1;
                        break;
                    case 8:
                        if (flag == 2)
                        {
                            Console.Write("twenty ");
                        }
                        Console.WriteLine("eight");
                        exit = 1;
                        break;
                    case 9:
                        if (flag == 2)
                        {
                            Console.Write("twenty ");
                        }
                        Console.WriteLine("nine ");
                        exit = 1;
                        break;
                    default:
                        break;
	            }
                break;
            case 2:
                {
                    decimals = userNum / 10;
                    switch (decimals)
                    {
                        case 1:
                            {
                                switch (userNum%10)
                                {
                                    case 0:
                                        Console.WriteLine("ten");
                                        exit = 1;
                                        break;
                                    case 1:
                                        Console.WriteLine("eleven");
                                        exit = 1;
                                        break;
                                    case 2:
                                        Console.WriteLine("twelve");
                                        exit = 1;
                                        break;
                                    case 3:
                                        Console.WriteLine("thriteen");
                                        exit = 1;
                                        break;
                                    case 4:
                                        Console.WriteLine("fourteen");
                                        exit = 1;
                                        break;
                                    case 5:
                                        Console.WriteLine("fifteen");
                                        exit = 1;
                                        break;
                                    case 6:
                                        Console.WriteLine("sixteen");
                                        exit = 1;
                                        break;
                                    case 7:
                                        Console.WriteLine("seventeen");
                                        exit = 1;
                                        break;
                                    case 8:
                                        Console.WriteLine("eighteen");
                                        exit = 1;
                                        break;
                                    case 9:
                                        Console.WriteLine("nineteen ");
                                        exit = 1;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        case 2:
                            {
                                state = 1;
                                flag = 2;
                            }
                            break;
                        default:
                            break;
                    }
                }
                break;
            default:
                break;
            }
        } while (exit==0);
    }
}