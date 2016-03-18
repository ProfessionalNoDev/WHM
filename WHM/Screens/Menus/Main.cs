using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM.Screens.Menus
{
    class Main : Screen
    {
        public override void Draw()
        {
            Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight / 2 - 2);
            Formatter.PrintCenterLine("New Game[N]");
            Formatter.PrintCenterLine("Exit Game[E]");
            Console.SetCursorPosition(4, Console.WindowHeight - 8);
            Console.Write("Inputs are converted -> upper case.");
            Console.SetCursorPosition(4, Console.WindowHeight - 6);
            Console.Write("Up-Arrow changes your current input to the last entered input.");
            Console.SetCursorPosition(4, Console.WindowHeight - 4);
            Console.Write("Input>");
        }
        public override void ProcessInput(string inpt)
        {
            switch(inpt.ToUpper())
            {
                case "N":
                    Game.scrn = new test();
                    break;
                case "E":
                    Game.Terminate();
                    break;
                default:
                    break;
            }
        }
    }
}
