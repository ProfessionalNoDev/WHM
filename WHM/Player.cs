using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WHM.BaseClasses;

namespace WHM
{
    public static class Player
    {
        //The statblock is a set of enums that describe the physical attributes of a characters body.
        public static StatBlock statBlock = new StatBlocks.Humans.PlayerDefault();

        //List of species that would find the thing attractive
        //List of cultures that would find the thing sociable

        //These are simply the names of advantages and disadvantages. The list is checked by other classes to look for relevant traits.
        public static List<string> traits = new List<string>();
        /// <summary>
        /// Writes all the Players data to Player.txt
        /// </summary>
        public static void Write()
        {
            string filePathTest = Directory.GetCurrentDirectory() + @"\Resources\";
            Directory.CreateDirectory(filePathTest);
            StreamWriter swrite = new StreamWriter(filePathTest + "Player.txt");
            swrite.Close();
        }
        /// <summary>
        /// Reads all the player data from Player.txt and returns a string that can be parsed for information by whatever specific parser.
        /// </summary>
        /// <returns></returns>
        public static string Read()
        {
            string filePathTest = Directory.GetCurrentDirectory() + @"\Resources\";
            StreamReader sread = new StreamReader(filePathTest + "Player.txt");
            string text = sread.ReadToEnd();
            return text;
        }
    }
}
