using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace simplefootstepsredux
{


    public class AiTaskLoudWander : AiTaskWander
    {
        string trigger = "wander";
        public AssetLocation stepSound;
        bool alreadycheckedforsound = false;
        public float stepTimer = new float();
        float stepTimerStop = 0.55f;
        public override bool ContinueExecute(float dt)
        {
            if (stepSound == null && !alreadycheckedforsound)
            {
                alreadycheckedforsound=true;
                SoundEntry trysound = simplefootstepsreduxModSystem.GetSoundEntry(entity, trigger);
                if (trysound != null)
                {
                    stepSound = new AssetLocation(trysound.soundFile);
                    stepTimerStop = trysound.soundTime;
                }
            }
            if (stepSound == null) { return base.ContinueExecute(dt); }
            stepTimer += dt;

            if (stepTimer >= stepTimerStop)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt); 

        }

        public AiTaskLoudWander(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskLoudFleeEntity : AiTaskFleeEntity
    {
        string trigger="fleeentity";
        public AssetLocation stepSound;
        bool alreadycheckedforsound = false;
        public float stepTimer = new float();
        float stepTimerStop = 0.55f;
        public override bool ContinueExecute(float dt)
        {
            if (stepSound == null && !alreadycheckedforsound)
            {
                alreadycheckedforsound = true;
                SoundEntry trysound = simplefootstepsreduxModSystem.GetSoundEntry(entity, trigger);
                if (trysound != null)
                {
                    stepSound = new AssetLocation(trysound.soundFile);
                    stepTimerStop = trysound.soundTime;
                }
            }
            if (stepSound == null) { return base.ContinueExecute(dt); }
            stepTimer += dt;

            if (stepTimer >= stepTimerStop)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt);

        }
        public AiTaskLoudFleeEntity(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskLoudSeekEntity : AiTaskSeekEntity
    {
        string trigger = "seekentity";
        public AssetLocation stepSound;
        bool alreadycheckedforsound = false;
        public float stepTimer = new float();
        float stepTimerStop = 0.55f;
        public override bool ContinueExecute(float dt)
        {
            if (stepSound == null && !alreadycheckedforsound)
            {
                alreadycheckedforsound = true;
                SoundEntry trysound = simplefootstepsreduxModSystem.GetSoundEntry(entity, trigger);
                if (trysound != null)
                {
                    stepSound = new AssetLocation(trysound.soundFile);
                    stepTimerStop = trysound.soundTime;
                }
            }
            if (stepSound == null) { return base.ContinueExecute(dt); }
            stepTimer += dt;

            if (stepTimer >= stepTimerStop)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt);

        }
        public AiTaskLoudSeekEntity(EntityAgent entity) : base(entity)
        {

        }
    }

    public class AiTaskLoudGetOutOfWater : AiTaskGetOutOfWater
    {
        string trigger = "getoutofwater";
        public AssetLocation stepSound;
        bool alreadycheckedforsound = false;
        public float stepTimer = new float();
        float stepTimerStop = 0.55f;
        public override bool ContinueExecute(float dt)
        {
            if (stepSound == null && !alreadycheckedforsound)
            {
                alreadycheckedforsound = true;
                SoundEntry trysound = simplefootstepsreduxModSystem.GetSoundEntry(entity, trigger);
                if (trysound != null)
                {
                    stepSound = new AssetLocation(trysound.soundFile);
                    stepTimerStop = trysound.soundTime;
                }
            }
            if (stepSound == null) { return base.ContinueExecute(dt); }
            stepTimer += dt;

            if (stepTimer >= stepTimerStop)
            {
                world.PlaySoundAt(stepSound, entity.Pos.X, entity.Pos.Y, entity.Pos.Z);
                stepTimer = 0;
            }

            return base.ContinueExecute(dt);

        }

        public AiTaskLoudGetOutOfWater(EntityAgent entity) : base(entity)
        {

        }
    }




    
}
