using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHM.BaseClasses;

namespace WHM.StatBlocks.Humans
{
    class PlayerDefault:StatBlock
    {
        public PlayerDefault()
        {
            strength = strengthLevels.Normal;
            speed = speedLevels.Normal;
            health = healthLevels.Normal;
            intellect = intellectLevels.Normal;
            hearing = hearingLevels.Normal;
            sight = sightLevels.Normal;
            smell = smellingLevels.Normal;
        }
    }
}
