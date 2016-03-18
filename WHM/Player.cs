using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WHM.Mechanics.Blocks;
using WHM.Mechanics.Bases;

namespace WHM
{
    public static class Player
    {
        
        public static StatBlock statBlock = new StatBlock();
        public static TraitBlock traitBlock = new TraitBlock();
        public static PlotBlock plotBlock = new PlotBlock();

        /// <summary>
        /// Writes all the Players data to Player.txt
        /// </summary>
        public static void Write()
        {
            string filePathTest = Directory.GetCurrentDirectory() + @"\Resources\";
            Directory.CreateDirectory(filePathTest);
            StreamWriter swrite = new StreamWriter(filePathTest + "Player.txt");
            foreach(KeyValuePair<string, Stat> entry in statBlock.attributes)
            {
                swrite.WriteLine("[{0}]({1})", entry.Key, entry.Value.current);
            }
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
