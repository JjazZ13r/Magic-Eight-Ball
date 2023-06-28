using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Magic_Eight_Ball
{
    internal class Console_Service
    {
        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
        public void Pause(string message = null)
        {
            if(message == null)
            {
                message = "Press any key to continue:";
            }
            Console.Write(message);
            Console.ReadKey();

        }
        public int PromptForInteger(string message, int minimum, int maximum, int? defaultValue = null)
        {
            string defaultPrompt = defaultValue.HasValue ? $"[{defaultValue}]: " : ": ";
            while (true)
            {
                Console.WriteLine($"{message}{defaultPrompt}");
                string input = Console.ReadLine();

                if (input.Trim().Length == 0 && defaultValue.HasValue)
                {
                    return defaultValue.Value;
                }
                if (int.TryParse(input, out int selection) && selection >= minimum && selection <= selection)
                {
                    return selection;
                }
                PrintError($"Number is out of range, please try again");
            }
        }
        public string PromptForString(string message, string defaultValue = null) 
        {
            string defaultPrompt = defaultValue == null ? ": " : $"[{defaultValue}]: ";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{message}{defaultPrompt}");
            Console.ResetColor();
            string input = Console.ReadLine();

            if(input.Length == 0 && defaultValue != null)
            {
                return defaultValue;
            }
            return input;
        }
    }
}
