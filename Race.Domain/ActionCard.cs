using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Race.Domain
{
    public class ActionCard<TPhase, TBonus> : ActionCard
        where TPhase : Phase
        where TBonus : Bonus
    {

    }

    public abstract class ActionCard
    {
        public static readonly ActionCard ExploreExtraCard = new ActionCard<ExplorePhase, ExtraCardBonus>();
        public static readonly ActionCard ExploreExtraChoice = new ActionCard<ExplorePhase, ExtraChoiceBonus>();
        public static readonly ActionCard Develop = new ActionCard<DevelopPhase, ReducedDevelopmentCostBonus>();
        //public static readonly ActionCard Settle = new ActionCard<SettlePhase, DrawAfterSettleBonus>();
        //public static readonly ActionCard ConsumeTrade = new ActionCard<ConsumePhase, TradeBonus>();
        //public static readonly ActionCard ConsumeDoubleVP = new ActionCard<ConsumePhase, DoubleVPBonus>();
        //public static readonly ActionCard Produce = new ActionCard<ProducePhase, ProduceOnWindfallBonus>();
    }
   
    public abstract class Phase
    {
        public abstract string Name { get; }
        public abstract void Execute(Game game, IEnumerable<ActionCardSelection> selections);
        public abstract int ExecutionOrder { get; }
    }

    //public class ProducePhase : Phase
    //{
    //}

    //public class ConsumePhase : Phase
    //{
    //}

    //public class SettlePhase : Phase
    //{
    //}

    public class DevelopPhase : Phase
    {
        public override string Name
        {
            get { return "Develop"; }
        }

        public override void Execute(Game game, IEnumerable<ActionCardSelection> selections)
        {

            var actions = from p in game.Players
                          let bonuses = from s in selections 
                                        where s.Player == p
                                        select s.SelectedBonus
                          select new DevelopAction(game, p, bonuses.SingleOrDefault());

            game.Input.DoDevelop(actions);
        }

        public override int ExecutionOrder
        {
            get { return 2; }
        }
    }

    public class ExplorePhase : Phase
    {
        public override string Name
        {
            get { return "Explore"; }
        }

        public override void Execute(Game game, IEnumerable<ActionCardSelection> selections)
        {
            var actions = game.Players.Select(p => new ExploreAction(game, p));
            game.Input.DoExplore(actions);
        }

        public override int ExecutionOrder
        {
            get { return 1; }
        }
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