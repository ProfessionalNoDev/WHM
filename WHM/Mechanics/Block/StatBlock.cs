using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHM.Mechanics.Base;

namespace WHM.Mechanics.Block
{
    public class StatBlock
    {
        public Dictionary<string, Stat> attributes = new Dictionary<string, Stat>();
        /// <summary>
        /// FillBlock labels all the attributes in the attributes dictionary and fills them with randomly generated stats 6d4.
        /// </summary>

        public void FillBlock()
        {
            attributes.Add("AGILITY", new Stat { rollBase = 15 });
            attributes.Add("BODY", new Stat { rollBase = 15 });
            attributes.Add("MIND", new Stat { rollBase = 15 });
            attributes.Add("PERCEPTION", new Stat { rollBase = 15 });
            attributes.Add("SPIRIT", new Stat { rollBase = 15 });
            Init();
        }
        private void Init()
        {
            foreach(KeyValuePair<string, Stat> entry in attributes)
            {
                entry.Value.SetRange();
            }
        }
        public void RollStats()
        {
            foreach(KeyValuePair<string, Stat> entry in attributes)
            {
                entry.Value.rollBase = statRoll();
            }
        }
        private int statRoll()
        {
            int temp = 0;
            for(int i = 0; i < 6; i++)
            {
                int rng = Game.rand.Next(1, 5);
                temp = temp + rng;
            }
            foreach(KeyValuePair<string, Stat> entry in attributes)
            {
                entry.Value.SetRange();
            }
            return temp;
        }
        public void ReadFromFile(string text)
        {
            int position = 0;
            int open = 0;
            int close = 0;
            int width = 0;
            List<string> key = new List<string>();
            List<string> value = new List<string>();
            for(int i = 0; i < attributes.Count; i++)
            {
                open = text.IndexOf("[", position);
                close = text.IndexOf("]", open);
                width = (close - open - 1);
                string temp = text.Substring(open + 1, width);
                foreach(KeyValuePair<string, Stat> entry in attributes)
                {
                    if(temp == entry.Key)
                    {
                        key.Add(temp);
                        Console.Write(temp + " ");
                        open = text.IndexOf("(", close);
                        close = text.IndexOf(")", open);
                        width = (close - open - 1);
                        temp = text.Substring(open + 1, width);
                        Console.Write(temp + " ");
                        value.Add(temp);
                        position = close;
                    }
                }
            }
            int index = 0;
            foreach(string str in key)
            {
                foreach(KeyValuePair<string, Stat> entry in attributes)
                {
                    if(str == entry.Key)
                    {
                        entry.Value.current = Convert.ToInt32(value[index]);
                    }
                }
                index = index + 1;
            }
            Console.WriteLine("Test: key length[{0}] value length[{1}].", key.Count, value.Count);
        }
    }
}
