using System;
using System.Collections.Generic;
using System.Linq;

namespace Race.Domain
{
    public class DrawDeck : CardZone
    {
        private DiscardPile _discards;

        public DrawDeck() : this(Enumerable.Empty<Card>(), null)
        {
        }

        public DrawDeck(IEnumerable<Card> startingCards, DiscardPile discards) : base(startingCards)
        {
            foreach (Card card in startingCards)
                card.MoveTo(this);

            _discards = discards;
        }

        public virtual void Shuffle()
        {
            RandomizeOrder();
        }

        public Card TopCard
        {
            get { return this.Cards.First(); }
        }

        public int CardCount
        {
            get { return Cards.Count(); }
        }

        public DiscardPile Discards
        {
            get { return _discards; }
        }

        protected override void RemoveCard(Card card)
        {
            base.RemoveCard(card);
            if(CardCount == 0)
            {
                _discards.MoveAllCards(this);
                //Shuffle();
            }
        }
    }

    public class DiscardPile : CardZone
    {
        public void MoveAllCards(CardZone targetZone)
        {
            var tempCards = new List<Card>(this.Cards);
            tempCards.Each(c => c.MoveTo(targetZone));
        }
    }
}