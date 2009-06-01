using System;
using System.Collections.Generic;

namespace Race.Domain
{
    public class Game
    {
        private readonly IList<Player> _players = new List<Player>();
        private readonly IEndCondition _endCondition;
        public GameInput Input { get; private set; }
        public DrawDeck DrawDeck { get; private set; }

        public Game() : this(new DrawDeck(), new GameInput(), new DefaultEndCondition() )
        {
            
        }

        public Game(DrawDeck drawDeck, GameInput input, IEndCondition endCondition)
        {
            DrawDeck = drawDeck;
            Input = input;
            _endCondition = endCondition;
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
            SetUp();
            
            while(!_endCondition.IsGameOver(this))
            {
                var round = new Round(this);
                round.Begin();
            }
        }

        private void SetUp()
        {
            DrawDeck.Shuffle();

            var discards = Input.GetOpeningDiscards();
            foreach (var d in discards)
                d.Apply();
        }
    }
}