
using System.Collections.Generic;
using System.Linq;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace simplefootstepsredux
{
    public class simplefootstepsreduxModSystem : ModSystem
    {
        public static List<SoundEntry> soundEntries;
        public static List<SoundEntry> SoundEntries
        {
            get {
                if (soundEntries == null)
                {
                    soundEntries = new List<SoundEntry>();
                    SoundEntry test=new SoundEntry();
                    test.mobMatchCode = "drifter";
                    test.soundTrigger = "wander";
                    test.soundFile = "simplefootstepsredux:sounds/creature/steps/npc";
                    test.soundTime = 0.55f;
                    soundEntries.Add(test);
                }
                return soundEntries;

            }
        }
        public override void Start(ICoreAPI api)
        {
            base.Start(api);

            AiTaskRegistry.Register("wander", typeof(AiTaskLoudWander));
            AiTaskRegistry.Register("fleeentity", typeof(AiTaskLoudFleeEntity));
            AiTaskRegistry.Register("seekentity", typeof(AiTaskLoudSeekEntity));
            AiTaskRegistry.Register("getoutofwater", typeof(AiTaskLoudGetOutOfWater));

            

            

        }
        public static SoundEntry GetSoundEntry(Entity forentity, string soundTrigger)
        {
            if (forentity == null) { return null; }
            SoundEntry find = SoundEntries.FirstOrDefault(x => forentity.Code.ToString().Contains(x.mobMatchCode) && x.soundTrigger == soundTrigger, null);
            return find;
        }
    }
}
