
using System.Collections.Generic;
using System.Linq;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;
using Vintagestory.Common;
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
            AiTaskRegistry.Register("stayclosetoentity", typeof(AiTaskLoudStayCloseToEntity));


        }

        public override void AssetsFinalize(ICoreAPI api)
        {
            soundEntries = new List<SoundEntry>();// = api.Assets.TryGet("simplefootstepsredux:config/soundentries.json").ToObject<List<SoundEntry>>();
            List<IAsset> many = api.Assets.GetMany("config/soundentries.json");
            foreach (IAsset asset in many)
            {
                List<SoundEntry>se=asset.ToObject<List<SoundEntry>>();
                if (se != null&&se.Count>0) { soundEntries.AddRange(se); }
            }
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
