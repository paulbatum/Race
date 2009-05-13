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

        protected void RandomizeOrder()
        {
            Random r = new Random();
            _cards.Sort((c1, c2) => r.Next());
        }

        public virtual void MoveCard(Card card, CardZone targetZone)
        {
            RemoveCard(card);
            AddCard(card, targetZone);
        }

        protected virtual void AddCard(Card card, CardZone targetZone)
        {
            targetZone._cards.Add(card);
        }

        protected virtual void RemoveCard(Card card)
        {
            _cards.Remove(card);
        }
    }

}