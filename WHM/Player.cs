using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WHM.Mechanics.Block;
using WHM.Mechanics.Base;

namespace WHM
{
    public static class Player
    {
        public static StatBlock statBlock = new StatBlock();
        public static TraitBlock traitBlock = new TraitBlock();
        public static PlotBlock plotBlock = new PlotBlock();

        public static void Write()
        {
            StreamWriter swrite = new StreamWriter("Player.txt");
            foreach(KeyValuePair<string, Stat> entry in statBlock.attributes)
            {
                swrite.WriteLine("[{0}]({1})", entry.Key, entry.Value.current);
            }
            swrite.Close();
        }
        public static string Read()
        {
            StreamReader sread = new StreamReader("Player.txt");
            string text = sread.ReadToEnd();
            return text;
        }
        public static void TestInit()
        {
            statBlock.FillBlock();
        }
    }
}
