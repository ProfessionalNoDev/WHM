using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM.Screens
{
    public static class Formatter
    {
        /// <summary>
        /// Prints the text in the center of the window and then return keys.
        /// </summary>
        /// <param name="text"></param>
        public static void PrintCenterLine(string text)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length, Console.CursorTop);
            Console.WriteLine(text);
        }
        /// <summary>
        /// Prints the text in the center of the window.
        /// </summary>
        /// <param name="text"></param>
        public static void PrintCenter(string text)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length, Console.CursorTop);
            Console.Write(text);
        }
        /// <summary>
        /// Prints the text input within a "box" that is dictated by the cursorleft position and the desired text width.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="cursorLeft"></param>
        /// <param name="width"></param>
        public static void PrintLongString(string text, int cursorLeft, int width)
        {
            int counter = 0;
            string[] words = text.Split(' ');
            foreach(var word in words)
            {
                if(counter + word.Length > width)
                {
                    counter = 0;
                    Console.SetCursorPosition(cursorLeft, Console.CursorTop + 1);
                    Console.Write(word + " ");
                    counter = counter + word.Length;
                }
                else
                {
                    Console.Write(word + " ");
                    counter = counter + word.Length;
                }
            }
        }
    }
}
