using System;
using System.Collections.Generic;
using System.Text;
using Magic_Eight_Ball;

namespace Magic_Eight_Ball
{
    internal class EightBallConsoleService : Console_Service
    {
        public void PrintMainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Magic Eight Ball Machine!");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("1. Ask me a Question...");
        }
        public void PlayTheEightBall()
        {
            int rannum = 0;
            Random r = new Random();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("What do you want to know?");
            Console.ResetColor();
            string userInput = Console.ReadLine();

            rannum = r.Next(1, 20);
            switch(rannum)
            {
                case 1: 
                    Console.WriteLine("It is certain.");
                    break;
                case 2: 
                    Console.WriteLine("As I see it, yes.");
                    break;
                case 3:
                    Console.WriteLine("It is decidedly so.");
                    break;
                case 4:
                    Console.WriteLine("Most likely");
                    break;
                case 5:
                    Console.WriteLine("Without a doubt");
                    break;
                case 6:
                    Console.WriteLine("Outlook good.");
                    break;
                case 7:
                    Console.WriteLine("Yes, definitely");
                    break;
                case 8:
                    Console.WriteLine("Yes");
                    break;
                case 9:
                    Console.WriteLine("You may rely on it");
                    break;
                case 10:
                    Console.WriteLine("Signs point to yes");
                    break;
                case 11:
                    Console.WriteLine("Reply haze, try again");
                    break;
                case 12:
                    Console.WriteLine("Ask again later");
                    break;
                case 13:
                    Console.WriteLine("Better not tell you now");
                    break;
                case 14:
                    Console.WriteLine("Cannot predict now");
                    break;
                case 15:
                    Console.WriteLine("Concentrate and ask again");
                    break;
                case 16:
                    Console.WriteLine("Don't count on it");
                    break;
                case 17:
                    Console.WriteLine("My reply is no");
                    break;
                case 18:
                    Console.WriteLine("My sources say no");
                    break;
                case 19:
                    Console.WriteLine("Outlook not so good");
                    break;
                case 20:
                    Console.WriteLine("Very doubtful");
                    break;
            }
            PlayTheEightBall();
        }
    }
}
