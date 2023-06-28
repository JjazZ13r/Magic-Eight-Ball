using System;
using System.Collections.Generic;
using System.Text;

namespace Magic_Eight_Ball
{
    public class Menu
    {
        private readonly EightBallConsoleService console = new EightBallConsoleService();
        public void Run()
        {
            while (true)
            {
                console.PrintMainMenu();
                int menuSelection = console.PromptForInteger("Please choose an option", 0, 1);

                if (menuSelection == 0)
                {
                    break;
                }
                if (menuSelection == 1)
                {
                    console.PlayTheEightBall();
                }
            }
        }
    }
}
