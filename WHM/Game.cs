using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHM.Screens;

namespace WHM
{
    /// <summary>
    /// The Game controls initialization, de-initialization, and the main loop.
    /// </summary>
    public static class Game
    {
        /// <summary>
        /// The scrn is the initialized screen that gets operated on in the loop using scrn.Draw() and scrn.Process(input).
        /// Change the screen by initializing it to a = new Screen() class, eg. inherited screen classes in Screens.Menus/Rooms
        /// </summary>
        public static Screen scrn = new Screen();
        public static string input = "";
        /// <summary>
        /// You can use rand for random number generation mainly with rand.Next(min, max).
        /// </summary>
        public static Random rand = new Random();
        /// <summary>
        /// Starts the game, initializes consoles, classes, and loop.
        /// </summary>
        public static void Initialize()
        {
            //Console Initialization
            Console.SetWindowSize(200, 60);
            Console.Title = "White Howl Mountain";
            //Class Initialization
            scrn = new Screens.Menus.Title();
            //Loop Initialization
            Loop();
        }
        /// <summary>
        /// The loop clears the screen, runs logic, draws the screen, and then gets input.
        /// </summary>
        private static void Loop()
        {
            while(scrn != null)
            {
                Console.Clear();
                //logic
                scrn.ProcessInput(input);
                //draw
                scrn.Draw();
                //input
                input = Console.ReadLine();
            }
        }
        /// <summary>
        /// Shuts down the game.
        /// </summary>
        public static void Terminate()
        {
            //This class will shutdown the program.
            Environment.Exit(0);
        }
    }
}
