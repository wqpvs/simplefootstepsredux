using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace simplefootstepsredux
{
    /// <summary>
    /// Data for mob sounds
    /// </summary>
    public class SoundEntry
    {
        public string mobMatchCode; //the mobs code or wildcard pattern this applies to, eg: drifter
        public string soundTrigger; //the name of the sound, eg: wander
                             //wander,fleeentity,seekentity,getoutofwater
        public string soundFile; //the full filename of the relevant sound eg: simplefootstepsredux:sounds/creature/steps/npc
        public float soundTime; //the delay between sounds eg: 0.55
    }
    
}
