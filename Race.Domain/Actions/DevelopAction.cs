using System;
using System.Collections.Generic;

namespace Race.Domain
{
    public class DevelopAction : GameAction
    {
        private readonly Game _game;
        private readonly Player _player;
        private readonly Bonus _bonus;

        public DevelopAction(Game game, Player player, Bonus bonus)
        {
            _game = game;
            _player = player;
            _bonus = bonus;
        }

        public void Build(DevelopmentCardPlacement placement)
        {
            foreach(Card c in placement.Payment)
                c.MoveTo(_game.DrawDeck.Discards);

            placement.Development.MoveTo(_player.Tableau);
            Completed = true;
        }

        public void Skip()
        {
            Completed = true;
        }
    }

    

    public class DevelopmentCardPlacement
    {
        public DevelopmentCardPlacement(Player player)
        {

        }

        public IEnumerable<Card> Payment
        {
            get { throw new NotImplementedException(); }
        }

        public Card Development
        {
            get { throw new NotImplementedException(); }
        }
    }
}