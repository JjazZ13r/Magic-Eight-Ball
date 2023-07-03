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
            Console.WriteLine("0. Exit");
        }
        public void PlayTheEightBall()
        {
            int rannum = 0;
            Random r = new Random();

            Console.ForegroundColor = ConsoleColor.Magenta;
<<<<<<< HEAD
            Console.WriteLine("What do you want to know? Enter 0 to exit program.");
=======
            Console.WriteLine("What do you want to know? Enter 0 to exit");
>>>>>>> 76ca1b5b7b74e9f306e898b621482ac22fc8cd95
            Console.ResetColor();
            string userInput = Console.ReadLine();
            if(userInput == "0")
            {
                Environment.Exit(0);
            }
            rannum = r.Next(1, 20);
            switch(rannum)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("It is certain.");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("As I see it, yes.");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("It is decidedly so.");
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Most likely");
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Without a doubt");
                    Console.ResetColor();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Outlook good.");
                    Console.ResetColor();
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes, definitely");
                    Console.ResetColor();
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes");
                    Console.ResetColor();
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You may rely on it");
                    Console.ResetColor();
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Signs point to yes");
                    Console.ResetColor();
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Reply haze, try again");
                    Console.ResetColor();
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ask again later");
                    Console.ResetColor();
                    break;
                case 13:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Better not tell you now");
                    Console.ResetColor();
                    break;
                case 14:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Cannot predict now");
                    Console.ResetColor();
                    break;
                case 15:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Concentrate and ask again");
                    Console.ResetColor();
                    break;
                case 16:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Don't count on it");
                    Console.ResetColor();
                    break;
                case 17:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("My reply is no");
                    Console.ResetColor();
                    break;
                case 18:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("My sources say no");
                    Console.ResetColor();
                    break;
                case 19:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Outlook not so good");
                    Console.ResetColor();
                    break;
                case 20:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Very doubtful");
                    Console.ResetColor();
                    break;
            }
            PlayTheEightBall();
        }
    }
}
