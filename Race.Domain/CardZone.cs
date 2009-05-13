using System;
using System.Collections.Generic;

namespace Race.Domain
{
    public delegate void CardZoneChanger(CardZone targetZone);
 
    public abstract class CardZone
    {
        private List<Card> _cards;

        protected CardZone()
        {
            _cards = new List<Card>();
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

        public virtual void MoveCard(Card card, CardZone targetZone, CardZoneChanger changer)
        {
            RemoveCard(card);
            targetZone.AddCard(card);
            changer(targetZone);
        }

        protected virtual void AddCard(Card card)
        {
            _cards.Add(card);
        }

        protected virtual void RemoveCard(Card card)
        {
            _cards.Remove(card);
        }
    }
}