using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM.Screens
{
    public class Screen
    {
        public virtual void Draw()
        {
            //This draws the screen
        }
        public virtual void ProcessInput(string inpt)
        {

        }
    }
}
