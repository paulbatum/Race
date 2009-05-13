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
        private Card _card1;
        private Card _card2;

        [SetUp]
        public void SetUp()
        {
            _card1 = new Card();
            _card2 = new Card();
        }

        [Test]
        public void Should_add_cards_passed_via_constructor()
        {
            var drawDeck = new DrawDeck(new List<Card> { _card1, _card2 }, new DiscardPile());
            drawDeck.CardCount.ShouldEqual(2);
            _card1.CurrentZone.ShouldEqual(drawDeck);
            _card2.CurrentZone.ShouldEqual(drawDeck);
        }

        [Test]
        public void Should_replace_top_card_when_moved()
        {
            var drawDeck = new DrawDeck(new List<Card> { _card1, _card2 }, new DiscardPile());
            drawDeck.TopCard.ShouldEqual(_card1);
            drawDeck.TopCard.MoveTo(drawDeck.Discards);
            drawDeck.TopCard.ShouldEqual(_card2);            
        }

        [Test]
        public void Should_refill_draw_deck_from_discards_when_empty()
        {
            var drawDeck = new DrawDeck(new List<Card> { _card1, _card2 }, new DiscardPile());
            drawDeck.TopCard.MoveTo(drawDeck.Discards);
            drawDeck.TopCard.MoveTo(new Hand());
            drawDeck.TopCard.ShouldEqual(_card1);
        }

        [Test]
        public void Should_shuffle_deck_after_being_refilled()
        {
            var cards = new List<Card>();
            30.Times(() => cards.Add(new Card()));
            var drawDeck = new DrawDeck(cards, new DiscardPile());

            30.Times(() => drawDeck.TopCard.MoveTo(drawDeck.Discards));

            var cardsAfterShuffle = new List<Card>();
            30.Times(() =>
                         {
                             cardsAfterShuffle.Add(drawDeck.TopCard);
                             drawDeck.TopCard.MoveTo(drawDeck.Discards);
                         });

            Assert.AreNotEqual(cards, cardsAfterShuffle);
        }
    }
}
