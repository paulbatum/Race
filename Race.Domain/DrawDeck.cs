using System;
using System.Collections.Generic;
using System.Linq;

namespace Race.Domain
{
    public class DrawDeck : CardZone
    {
        private DiscardPile _discards;

        public DrawDeck(IEnumerable<Card> startingCards, DiscardPile discards) : base(startingCards)
        {
            _discards = discards;
        }

        public virtual void Shuffle()
        {
            
        }

        public Card TopCard
        {
            get { throw new NotImplementedException(); }
        }

        public int CardCount
        {
            get { return Cards.Count(); }
        }
    }

    public class DiscardPile : CardZone
    {
        
    }
}