using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM.Mechanics.Bases
{
    public class Stat:Base
    {
        public int rollBase;
        public int current;
        private int min;
        private int max;
        public bool Check(int difficulty)
        {
            if(difficulty > current)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void SetRange()
        {
            min = rollBase - 4;
            max = rollBase + 4;
            current = rollBase;
        }
    }
}
