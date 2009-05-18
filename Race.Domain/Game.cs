using System.Collections.Generic;

namespace Race.Domain
{
    public class Game
    {
        private readonly IList<Player> _players = new List<Player>();
        private IEndCondition _endCondition;
        public GameInput Input { get; private set; }
        public GameOutput Output { get; private set; }
        public DrawDeck DrawDeck { get; private set; }

        public Game() : this(new DrawDeck(), new GameInput(), new GameOutput(), new DefaultEndCondition() )
        {
            
        }

        public Game(DrawDeck drawDeck, GameInput input, GameOutput output, IEndCondition endCondition)
        {
            DrawDeck = drawDeck;
            Output = output;
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
            DrawDeck.Shuffle();
            while(!_endCondition.IsGameOver(this))
            {
                var round = new Round(this);
                round.Execute();
            }
        }
        
    }

    //public class DrawCardAction
    //{
    //    private DrawDeck _drawDeck;
    //    private Player _player;

    //    public DrawCardAction(DrawDeck drawDeck, Player player)
    //    {
    //        _drawDeck = drawDeck;
    //        _player = player;
    //    }

    //    public void Execute()
    //    {
    //        //_drawDeck.MoveCard(_drawDeck.TopCard, _player.Hand);
    //        _drawDeck.TopCard.MoveTo(_player.Hand);
    //    }
    //}
}