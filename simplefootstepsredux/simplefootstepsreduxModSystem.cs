
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
                    SoundEntry testWander=new SoundEntry();
                    testWander.mobMatchCode = "drifter";
                    testWander.soundTrigger = "wander";
                    testWander.soundFile = "simplefootstepsredux:sounds/creature/steps/npc";
                    testWander.soundTime = 0.55f;
                    soundEntries.Add(testWander);
                    SoundEntry testFlee = new SoundEntry();
                    testFlee.mobMatchCode = "drifter";
                    testFlee.soundTrigger = "fleeentity";
                    testFlee.soundFile = "simplefootstepsredux:sounds/creature/steps/npc";
                    testFlee.soundTime = 0.25f;
                    SoundEntry testSeek = new SoundEntry();
                    testSeek.mobMatchCode = "drifter";
                    testSeek.soundTrigger = "seekentity";
                    testSeek.soundFile = "simplefootstepsredux:sounds/creature/steps/drifter";
                    testSeek.soundTime = 0.35f;
                    soundEntries.Add(testSeek);
                    SoundEntry testWater = new SoundEntry();
                    testSeek.mobMatchCode = "drifter";
                    testSeek.soundTrigger = "getoutofwater";
                    testSeek.soundFile = "simplefootstepsredux:sounds/creature/steps/water";
                    testSeek.soundTime = 0.75f;
                    soundEntries.Add(testSeek);

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
