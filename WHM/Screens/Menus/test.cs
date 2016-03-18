using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM.Screens.Menus
{
    class test : Screen
    {
        public override void Draw()
        {
            Console.SetCursorPosition(4, 8);
            Console.Write("[R] to return.");
            Console.SetCursorPosition(4, 12);
            Console.Write("[C] to Character Sheet.");
            Console.SetCursorPosition(4, Console.WindowHeight - 4);
            Console.Write("Input>");
        }
        public override void ProcessInput(string inpt)
        {
            switch(inpt.ToUpper())
            {
                case "R":
                    Game.scrn = new Main();
                    break;
                case "C":
                    Game.scrn = new CharacterSheet();
                    break;
                default:
                    break;
            }
        }
    }
}
