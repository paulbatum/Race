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

    
}