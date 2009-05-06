using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Race.Domain;

namespace Race.Tests
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void Draw_deck_is_refilled_from_discards_when_empty()
        {
            var discards = new DiscardPile();
            var drawDeck = new DrawDeck(new List<Card> {new Card(), new Card()}, discards);
            var hand = new Hand();

            drawDeck.MoveCard(drawDeck.TopCard, discards);
            drawDeck.CardCount.ShouldEqual(1);

            

            
        }
    }
}
