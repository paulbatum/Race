using System;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using Race.Domain;

namespace Race.Tests
{
    [TestFixture]
    public class RaceTests
    {
        [Test]
        public void Can_create_game_with_two_players()
        {
            var game = new Game();
            game.AddPlayer(new Player {Name = "Paul"});
            game.AddPlayer(new Player {Name = "Tristan"});

            game.Players.ShouldHaveCount(2);

        }

        [Test]
        public void Deck_is_shuffled_on_game_start()
        {
            var deckMock = new Mock<DrawDeck>();
                
            var game = new Game(deckMock.Object, null, null, new GameImmediatelyOverEndCondition());
            game.Start();

            deckMock.Verify(x => x.Shuffle());

        }

        private class GameImmediatelyOverEndCondition : IEndCondition
        {
            public bool IsGameOver(Game game)
            {
                return true;
            }
        }
    }
}
