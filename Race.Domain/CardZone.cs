using System;
using System.Collections.Generic;
using System.Linq;

namespace Race.Domain
{
    public class CardZone
    {
        private List<Card> _cards;

        public CardZone()
        {
            _cards = new List<Card>();
        }

        protected IEnumerable<Card> Cards
        {
            get { return _cards;}
        }

        public int CardCount
        {
            get { return this.Cards.Count(); }
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

        public void MoveAll(CardZone targetZone)
        {
            IList<Card> allCards = new List<Card>(this._cards);
            foreach(Card c in allCards)
                c.MoveTo(targetZone);
        }
    }
}