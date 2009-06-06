using System;

namespace Race.Domain
{
    public class ActionCard<TPhase, TBonus> : ActionCard
        where TPhase : Phase
        where TBonus : Bonus
    {
        public PhaseType Phase
        {
            get
            {
                return new PhaseType(typeof (TPhase));
            }
        }

    }


    public abstract class ActionCard
    {
        public static readonly ActionCard ExploreExtraCard =    new ActionCard<ExplorePhase, ExtraCardBonus>();
        public static readonly ActionCard ExploreExtraChoice =  new ActionCard<ExplorePhase, ExtraChoiceBonus>();
        public static readonly ActionCard Develop =             new ActionCard<DevelopPhase, ReducedDevelopmentCostBonus>();
        public static readonly ActionCard Settle =              new ActionCard<SettlePhase,  DrawAfterSettleBonus>();
        public static readonly ActionCard ConsumeTrade =        new ActionCard<ConsumePhase, TradeBonus>();
        public static readonly ActionCard ConsumeDoubleVP =     new ActionCard<ConsumePhase, DoubleVPBonus>();
        public static readonly ActionCard Produce =             new ActionCard<ProducePhase, ProduceOnWindfallBonus>();
    }

    public class PhaseType
    {
        private readonly Type _type;

        public PhaseType(Type type)
        {
            _type = type;
        }

        public string Name
        {
            get { return _type.Name; }
        }
    }

    public class Phase
    {
        
    }

    public class ProducePhase : Phase
    {
    }

    public class ConsumePhase : Phase
    {
    }

    public class SettlePhase : Phase
    {
    }

    public class DevelopPhase : Phase
    {
    }

    public class ExplorePhase : Phase
    {
    }


    public class ProduceOnWindfallBonus : Bonus
    {
    }

    public class DoubleVPBonus : Bonus
    {
    }

    public class TradeBonus : Bonus
    {
    }

    public class DrawAfterSettleBonus : Bonus
    {
    }

    public class ReducedDevelopmentCostBonus : Bonus
    {
    }

    public class ExtraChoiceBonus : Bonus
    {
    }

    public class ExtraCardBonus : Bonus
    {
    }

    

    public abstract class Bonus
    {
        
    }

}