using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

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
    }

    public class Player
    {
        public string Name { get; set; }
    }

    public class Game
    {
        private IEnumerable<Player> _players;

        public void AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> Players
        {
            get { return _players; }
        }
    }
}
