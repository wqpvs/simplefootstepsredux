using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace simplefootstepsredux
{

    public class AiTaskLoudDrifterWander : AiTaskWander
    {

        public AssetLocation stepSound = new AssetLocation("simplefootstepsredux", "sounds/creature/steps/drifter");
        public float stepTimer = new float();
        

        public override bool ContinueExecute(float dt)
        {
            stepTimer += dt;

            if (stepTimer >= 0.84)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z,null,true,20f,0.5f);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt); ;

        }
        public AiTaskLoudDrifterWander(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskLoudDrifterSeekEntity : AiTaskSeekEntity
    {

        public AssetLocation stepSound = new AssetLocation("simplefootstepsredux", "sounds/creature/steps/drifter");
        public float stepTimer = new float();


        public override bool ContinueExecute(float dt)
        {
            stepTimer += dt;

            if (stepTimer >= 0.4)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z, null, true, 20f, 0.5f);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt); ;

        }
        public AiTaskLoudDrifterSeekEntity(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskLoudDrifterFleeEntity : AiTaskFleeEntity
    {

        public AssetLocation stepSound = new AssetLocation("simplefootstepsredux", "sounds/creature/steps/drifter");
        public float stepTimer = new float();


        public override bool ContinueExecute(float dt)
        {
            stepTimer += dt;

            if (stepTimer >= 0.4)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z, null, true, 20f, 0.5f);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt); ;

        }
        public AiTaskLoudDrifterFleeEntity(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskLoudDrifterGetOutOfWater : AiTaskGetOutOfWater
    {

        public AssetLocation stepSound = new AssetLocation("simplefootstepsredux", "sounds/creature/steps/water");
        public float stepTimer = new float();
        

        public override bool ContinueExecute(float dt)
        {
            stepTimer += dt;

            if (stepTimer >= 0.84)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z,null,true,20f,0.5f);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt); ;

        }
        public AiTaskLoudDrifterGetOutOfWater(EntityAgent entity) : base(entity)
        {

        }
    }

    





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




    public class AiTaskSilentWander : AiTaskWander 
    {
        public AiTaskSilentWander(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskSilentFleeEntity : AiTaskFleeEntity
    {
        public AiTaskSilentFleeEntity(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskSilentSeekEntity : AiTaskSeekEntity
    {
        public AiTaskSilentSeekEntity(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskSilentGetOutOfWater : AiTaskGetOutOfWater 
    {
        public AiTaskSilentGetOutOfWater(EntityAgent entity) : base(entity)
        {

        }
    }
}
