using System;
using System.Collections.Generic;

namespace Race.Domain
{
    public class Game
    {
        private readonly DrawDeck _drawDeck;
        private IList<Player> _players = new List<Player>();

        public Game(DrawDeck drawDeck)
        {
            _drawDeck = drawDeck;
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public IEnumerable<Player> Players
        {
            get { return _players; }
        }

        public void Start()
        {
            _drawDeck.Shuffle();
        }
    }

    public class DrawCardAction
    {
        private DrawDeck _drawDeck;
        private Player _player;

        public DrawCardAction(DrawDeck drawDeck, Player player)
        {
            _drawDeck = drawDeck;
            _player = player;
        }

        public void Execute()
        {
            //_drawDeck.MoveCard(_drawDeck.TopCard, _player.Hand);
            _drawDeck.TopCard.MoveTo(_player.Hand);
        }
    }

    public class NullZone : CardZone
    {
        protected override void AddCard(Card card)
        {
            // NO OP
        }

        protected override void RemoveCard(Card card)
        {
            // NO OP
        }
    }
}