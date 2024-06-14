
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace simplefootstepsredux
{
    public class simplefootstepsreduxModSystem : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);

            AiTaskRegistry.Register("wander", typeof(AiTaskLoudWander));
            AiTaskRegistry.Register("fleeentity", typeof(AiTaskLoudFleeEntity));
            AiTaskRegistry.Register("seekentity", typeof(AiTaskLoudSeekEntity));
            AiTaskRegistry.Register("getoutofwater", typeof(AiTaskLoudGetOutOfWater));

            // Seperate Tasks for Drifters, since I want a different sounding footstep so players can easily tell them apart
            // Would be much cleaner and easier if I could pass a variable from the JSON to use a different sound effect
            // but not sure if thats possible so I'm just hardcoding it here c:

            AiTaskRegistry.Register("drifterwander", typeof(AiTaskLoudDrifterWander));
            AiTaskRegistry.Register("drifterseekentity", typeof(AiTaskLoudDrifterSeekEntity));
            AiTaskRegistry.Register("drifterfleeentity", typeof(AiTaskLoudDrifterFleeEntity));
            AiTaskRegistry.Register("driftergetoutofwater", typeof(AiTaskLoudDrifterGetOutOfWater));

            // Reclassify vanilla aitasks w/ "silent-" prefix for use to override manually

            AiTaskRegistry.Register("silent-wander", typeof(AiTaskSilentWander));
            AiTaskRegistry.Register("silent-fleeentity", typeof(AiTaskSilentFleeEntity));
            AiTaskRegistry.Register("silent-seekentity", typeof(AiTaskSilentSeekEntity));
            AiTaskRegistry.Register("silent-getoutofwater", typeof(AiTaskSilentGetOutOfWater));

        }
    }
}
