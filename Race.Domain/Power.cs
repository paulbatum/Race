namespace Race.Domain
{
    public abstract class Power
    {
        public abstract bool AppliesTo(GameAction action);
    }

    
}