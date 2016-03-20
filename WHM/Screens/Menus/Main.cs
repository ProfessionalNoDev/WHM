using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM.Screens.Menus
{
    class Title : Screen
    {
        public Title()
        {
            title = "Screen: TITLE";
        }
        public override void Draw()
        {
            Console.SetCursorPosition(Console.CursorLeft, Console.WindowHeight / 2 - 2);
            Formatter.PrintCenterLine("Test Menu[T]");
            Formatter.PrintCenterLine("Exit Game[E]");
            Console.SetCursorPosition(4, Console.WindowHeight - 8);
            Console.Write("Inputs are converted -> upper case.");
            Console.SetCursorPosition(4, Console.WindowHeight - 6);
            Console.Write("Up-Arrow changes your current input to the last entered input.");
            base.Draw();
        }
        public override void ProcessInput(string inpt)
        {
            switch(inpt.ToUpper())
            {
                case "T":
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
