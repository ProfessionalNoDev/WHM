using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM.Screens.Menus
{
    class CharacterSheet : Screen
    {
        public override void Draw()
        {
            Console.SetCursorPosition(4, 4);
            Console.Write("[D] to roll for your players statblock.");
            Console.SetCursorPosition(4, 5);
            Console.Write("[W] to write it to the file.");
            Console.SetCursorPosition(4, 7);
            Console.Write("[R] to read from the file.");
            Console.SetCursorPosition(4, 8);
            Console.Write("[T] to test menu.");
            Console.SetCursorPosition(4, 12);
            Console.Write("AGILITY = {0}", Player.statBlock.attributes["AGILITY"].current);
            Console.SetCursorPosition(4, 13);
            Console.Write("BODY = {0}", Player.statBlock.attributes["BODY"].current);
            Console.SetCursorPosition(4, 14);
            Console.Write("MIND = {0}", Player.statBlock.attributes["MIND"].current);
            Console.SetCursorPosition(4, 15);
            Console.Write("PERCEPTION = {0}", Player.statBlock.attributes["PERCEPTION"].current);
            Console.SetCursorPosition(4, 16);
            Console.Write("SPIRIT = {0}", Player.statBlock.attributes["SPIRIT"].current);
            Console.SetCursorPosition(4, Console.WindowHeight - 4);
            Console.Write("Input>");
        }
        public override void ProcessInput(string inpt)
        {
            switch(inpt.ToUpper())
            {
                case "D":
                    Player.statBlock.RollStats();
                    break;
                case "W":
                    Player.Write();
                    break;
                case "T":
                    Game.scrn = new test();
                    break;
                case "R":
                    Console.SetCursorPosition(40, 12); Player.statBlock.ReadFromFile(Player.Read());
                    break;
                default:
                    break;
            }
        }
    }
}
