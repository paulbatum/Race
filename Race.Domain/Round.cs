using System;
using System.Collections.Generic;
using System.Linq;

namespace Race.Domain
{
    public class Round
    {
        private readonly Game _game;

        public Round(Game game)
        {
            _game = game;
        }

        public void Begin()
        {
            IEnumerable<ActionCardSelection> actionCardSelections = _game.Input.GetActionCardSelections();
            IEnumerable<Phase> phases = GetPhases(actionCardSelections);

            
        }

        private IEnumerable<Phase> GetPhases(IEnumerable<ActionCardSelection> selections)
        {
            var results = from s in selections
                          group s by s.SelectedActionCard.Phase;
                          
            
            
        }


    }

    public class Phase
    {
        private readonly IDictionary<Player, BonusType> _bonuses;

        public Phase()
        {
            _bonuses = new Dictionary<Player, BonusType>();
        }

        public virtual void AddBonus(Player player, BonusType bonus)
        {
            _bonuses[player] = bonus;
        }

        public static Phase Create(PhaseType type)
        {
            switch(type)
            {
                case PhaseType.Explore:
                    return new ExplorePhase();
                case PhaseType.Develop:
                    return new DevelopPhase();
                case PhaseType.Settle:
                    return new SettlePhase();
                case PhaseType.Consume:
                    return new ConsumePhase();
                case PhaseType.Produce:
                    return new ProducePhase();
                default:
                    throw new NotImplementedException();
            }
        }
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
}