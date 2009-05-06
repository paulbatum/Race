using System;
using System.Collections.Generic;

namespace Race.Domain
{
    public class Player
    {
        public string Name { get; set; }

        public Hand Hand
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class Hand : CardZone
    {
        
    }

    public abstract class CardZone
    {
        private List<Card> _cards;

        public CardZone()
        {
            _cards = new List<Card>();
        }

        protected CardZone(IEnumerable<Card> startingCards)
        {
            _cards = new List<Card>(startingCards);
        }

        protected IEnumerable<Card> Cards
        {
            get { return _cards;}
        }

        public virtual void MoveCard(Card card, CardZone targetZone)
        {
            _cards.Remove(card);
            targetZone._cards.Add(card);
        }
    }

}