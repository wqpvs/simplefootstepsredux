
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

        public override void AssetsFinalize(ICoreAPI api)
        {
            soundEntries = api.Assets.TryGet("simplefootstepsredux:config/soundentries.json").ToObject<List<SoundEntry>>();
            base.AssetsFinalize(api);
        }

        public static SoundEntry GetSoundEntry(Entity forentity, string soundTrigger)
        {
            if (forentity == null) { return null; }
            if (SoundEntries == null) { return null; }
            SoundEntry find = SoundEntries.FirstOrDefault(x => forentity.Code.ToString().Contains(x.mobMatchCode) && x.soundTrigger == soundTrigger, null);
            return find;
        }
    }
}
