using System;
using System.Collections.Generic;
using System.Linq;

namespace Race.Domain
{
    public class Round
    {
        private readonly Game _game;
        private readonly IList<Phase> _phases;

        public Round(Game game)
        {
            _game = game;
            _phases = new List<Phase> {new ExplorePhase(), new DevelopPhase(), new SettlePhase(), new ConsumePhase(), new ProducePhase()};
        }

        public Round(Game game, IList<Phase> phases)
        {
            _game = game;
            _phases = phases;
        }

        public void Execute()
        {
            IEnumerable<ActionCardSelection> actionCardSelections = _game.Input.GetActionCardSelections();
            
            foreach(Phase phase in _phases)
            {
                var matching = actionCardSelections.Where(s => s.SelectedPhase == phase.Name);
                
                if(matching.Count() == 0)
                    continue;

                phase.Execute(_game, matching);
            }

            var discardPhase = new DiscardPhase(_game);
            discardPhase.Execute();            
        }



    }

    public class DiscardPhase
    {
        public DiscardPhase(Game game)
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}