
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

            

            

        }
    }
}
