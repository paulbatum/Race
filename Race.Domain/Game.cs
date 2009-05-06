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
            _drawDeck.MoveCard(_drawDeck.TopCard, _player.Hand);
        }
    }

    public class Card
    {
        private CardZone _currentZone;

        public Card()
        {
            _currentZone = new NullZone();
        }

        public void MoveTo(CardZone targetZone)
        {            
            _currentZone.MoveCard(this, targetZone);
            _currentZone = targetZone;
        }
    }

    public class NullZone : CardZone
    {
        public override void MoveCard(Card card, CardZone targetZone)
        {
            
        }
    }
}