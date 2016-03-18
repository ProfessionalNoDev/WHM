using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHM.Screens;

namespace WHM
{
    public static class Game
    {
        public static Screen scrn = new Screen();
        public static string input = "";
        public static Random rand = new Random();
        public static Scene sn = new Scene();

        //initialize
        public static void Initialize()
        {
            Console.SetWindowSize(200, 60);
            Console.Title = "White Howl Mountain";
            //scrn needs to be set to not null, aka startscreen or something.
            Player.TestInit();
            scrn = new Screens.Menus.Main();
            Loop();
        }
        public static void Loop()
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
        //terminate
        public static void Terminate()
        {
            Environment.Exit(0);
        }
    }
}
