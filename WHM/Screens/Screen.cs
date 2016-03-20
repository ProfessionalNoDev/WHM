using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM.Screens
{
    public class Screen
    {
        public string title = "";
        public virtual void Draw()
        {
            //This draws the screen
            Console.SetCursorPosition(4, 2);
            Console.Write(title);
            Console.SetCursorPosition(4, Console.WindowHeight - 4);
            Console.Write("Input>");
        }
        public virtual void ProcessInput(string inpt)
        {

        }
    }
}
