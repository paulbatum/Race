namespace Race.Domain
{
    public class ActionCard
    {
        public PhaseType PhaseType { get; private set; }
        public BonusType BonusType { get; private set; }

        public ActionCard(PhaseType phaseType, BonusType bonusType)
        {
            PhaseType = phaseType;
            BonusType = bonusType;
        }

        public static readonly ActionCard ExploreExtraCard =    new ActionCard(PhaseType.Explore, BonusType.ExtraCard);
        public static readonly ActionCard ExploreExtraChoice =  new ActionCard(PhaseType.Explore, BonusType.ExtraChoice);
        public static readonly ActionCard Develop =             new ActionCard(PhaseType.Develop, BonusType.ReducedDevelopmentCost);
        public static readonly ActionCard Settle =              new ActionCard(PhaseType.Settle,  BonusType.DrawAfterSettle);
        public static readonly ActionCard ConsumeTrade =        new ActionCard(PhaseType.Consume, BonusType.Trade);
        public static readonly ActionCard ConsumeDoubleVP =     new ActionCard(PhaseType.Consume, BonusType.DoubleVP);
        public static readonly ActionCard Produce =             new ActionCard(PhaseType.Produce, BonusType.ProduceOnWindfall);
    }

    public enum PhaseType
    {
        Explore,
        Develop,
        Settle,
        Consume,
        Produce
    }

    public enum BonusType
    {
        ExtraCard,
        ExtraChoice,
        ReducedDevelopmentCost,
        DrawAfterSettle,
        Trade,
        DoubleVP,
        ProduceOnWindfall
    }
}