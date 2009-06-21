using System.Collections.Generic;

namespace Race.Domain
{
    public class ExploreAction : GameAction
    {
        private readonly Game _game;
        private readonly Player _player;
        private readonly CardZone _choiceZone;

        public ExploreAction(Game game, Player player)
        {
            _game = game;
            _player = player;
            _choiceZone = new CardZone();

            SetAsideCards();                    
        }

        private void SetAsideCards()
        {
            _game.DrawDeck.TopCard.MoveTo(_choiceZone);
            _game.DrawDeck.TopCard.MoveTo(_choiceZone);    
        }

        public void Keep(IEnumerable<Card> keeping)
        {
            foreach(Card c in keeping)
                c.MoveTo(_player.Hand);

            _choiceZone.MoveAll(_game.DrawDeck.Discards);
            Completed = true;
        }
    }
}