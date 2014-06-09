using System;
using System.Collections.Generic;
using System.Threading;

struct Dwarf
{
    public int xMinus;
    public int x;
    public int xPlus;
    public int y;
    public char c;
    public char cMinus;
    public char cPlus;
    public ConsoleColor color;
}
struct Rocks
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}
class FallingRocks
{
    static void PrintDwarfOnPositon(int x,int xPlus,int xMinus, int y, char c,char cPlus,char cMinus, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(xMinus, y);
        Console.ForegroundColor = color;
        Console.Write(cMinus);
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
        Console.SetCursorPosition(xPlus, y);
        Console.ForegroundColor = color;
        Console.Write(cPlus);
    }
    static void PrintOnPositon(int x,int y,char c,ConsoleColor color=ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPositon(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main()
    {
        ConsoleColor[] colors =
        {
            ConsoleColor.Yellow,
            ConsoleColor.Green,
            ConsoleColor.Cyan,
            ConsoleColor.Blue,
            ConsoleColor.DarkGreen,
            ConsoleColor.Magenta,
        };
        int speed = 100;
        double score = 0.0;
        char[] randomChars = "^@*&+%$#!.;".ToCharArray();
        int playfieldWidth = 20;
        int livesCount = 3;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 40;
        Dwarf dwarf = new Dwarf();
        dwarf.xMinus = 8;
        dwarf.x = 9;
        dwarf.xPlus = 10;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.cMinus = '(';
        dwarf.c = '0';
        dwarf.cPlus = ')';
        dwarf.color = ConsoleColor.White;
        Random randomGenerator = new Random();
        List<Rocks> objects = new List<Rocks>();
        while (true)
        {
            speed++;
            if(speed>520)
            {
                speed = 520;
            }
            bool hitted = false;
            {
                Rocks newRock = new Rocks();
                newRock.color = colors[randomGenerator.Next(0,colors.Length)];
                newRock.x = randomGenerator.Next(0, playfieldWidth);
                newRock.y = 0;
                int i = randomGenerator.Next(0, randomChars.Length);
                newRock.c = randomChars[i];
                objects.Add(newRock);
            }
            if(Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key==ConsoleKey.LeftArrow)
                {
                    if (dwarf.xMinus - 1 >= 0&&dwarf.x-1>dwarf.xMinus-1&&dwarf.xPlus-1>dwarf.x-1)
                    {
                        dwarf.xMinus = dwarf.xMinus - 1;
                        dwarf.x = dwarf.x - 1;
                        dwarf.xPlus = dwarf.xPlus - 1;
                    }
                }
                else if(pressedKey.Key==ConsoleKey.RightArrow)
                {
                    if (dwarf.xMinus+1<dwarf.x+1&&dwarf.x+1<dwarf.xPlus+1&&dwarf.xPlus + 1 < playfieldWidth)
                    {
                        dwarf.xMinus = dwarf.xMinus + 1;
                        dwarf.x = dwarf.x + 1;
                        dwarf.xPlus = dwarf.xPlus + 1;
                    }
                }
                else if (pressedKey.Key==ConsoleKey.P)
                {
                    PrintStringOnPositon(Console.WindowWidth / 2, Console.WindowHeight / 2, "PAUSE", ConsoleColor.Red);
                    ConsoleKeyInfo pauseKey = Console.ReadKey(true);
                    if (pauseKey.Key==ConsoleKey.P)
                    {
                        continue;
                    }
                }
            }
            List < Rocks > newList = new List<Rocks>();
            for (int i = 0; i < objects.Count; i++)
            {
                Rocks oldRock = objects[i];
                Rocks newRock = new Rocks();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;
                if ((newRock.y == dwarf.y && newRock.x == dwarf.x) || (newRock.y == dwarf.y && newRock.x == dwarf.xMinus) || (newRock.y == dwarf.y && newRock.x == dwarf.xPlus))
                {
                    livesCount--;
                    hitted = true;
                    if (livesCount<=0)
                    {
                        PrintStringOnPositon(playfieldWidth + 2, 7, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPositon(playfieldWidth + 2, 9, "Press [enter]...", ConsoleColor.Red);
                        PrintStringOnPositon(playfieldWidth + 4, 10, "...to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if(newRock.y<Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }
            objects=newList;
            Console.Clear();
            if (hitted)
            {
                PrintOnPositon(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
                Console.Beep();
                objects.Clear();
            }
            else
            {
                PrintDwarfOnPositon(dwarf.x,dwarf.xPlus,dwarf.xMinus, dwarf.y, dwarf.c,dwarf.cPlus,dwarf.cMinus, dwarf.color);
            }
            foreach (Rocks rock in objects)
            {
                PrintOnPositon(rock.x, rock.y, rock.c, rock.color);
            }

            //draw system info
            PrintStringOnPositon(playfieldWidth+2,4,"Lives: "+livesCount,ConsoleColor.DarkYellow);
            score += 100;
            PrintStringOnPositon(playfieldWidth + 2, 5, "Score: "+score, ConsoleColor.DarkYellow);
            PrintStringOnPositon(playfieldWidth + 2, 6, "Speed: " + speed, ConsoleColor.DarkYellow);
            PrintStringOnPositon(playfieldWidth + 2, 12, "Press 'P' to...", ConsoleColor.Magenta);
            PrintStringOnPositon(playfieldWidth + 2, 13, "...pause the game.", ConsoleColor.Magenta);
            Thread.Sleep(600 - speed);
        }
    }
}