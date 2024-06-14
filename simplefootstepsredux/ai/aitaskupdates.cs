using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace simplefootstepsredux
{


    public class AiTaskLoudWander : AiTaskWander
    {
        public AssetLocation stepSound = new AssetLocation("simplefootstepsredux", "sounds/creature/steps/npc");
        public float stepTimer = new float();

        public override bool ContinueExecute(float dt)
        {
            stepTimer += dt;

            if (stepTimer >= 0.55)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt); ; 

        }

        public AiTaskLoudWander(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskLoudFleeEntity : AiTaskFleeEntity
    {
        public AssetLocation stepSound = new AssetLocation("simplefootstepsredux", "sounds/creature/steps/npc");
        public float stepTimer = new float();
        public override bool ContinueExecute(float dt)
        {
            stepTimer += dt;

            if (stepTimer >= 0.3)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt); ;

        }
        public AiTaskLoudFleeEntity(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskLoudSeekEntity : AiTaskSeekEntity
    {
        public AssetLocation stepSound = new AssetLocation("simplefootstepsredux", "sounds/creature/steps/npc");
        public float stepTimer = new float();
        public override bool ContinueExecute(float dt)
        {
            stepTimer += dt;

            if (stepTimer >= 0.3)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt); ;

        }
        public AiTaskLoudSeekEntity(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskLoudGetOutOfWater : AiTaskGetOutOfWater
    {
        public AssetLocation stepSound = new AssetLocation("simplefootstepsredux", "sounds/creature/steps/water");
        public float stepTimer = new float();

        public override bool ContinueExecute(float dt)
        {
            stepTimer += dt;

            if (stepTimer >= 0.55)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt); ; 

        }

        public AiTaskLoudGetOutOfWater(EntityAgent entity) : base(entity)
        {

        }
    }




    
}
