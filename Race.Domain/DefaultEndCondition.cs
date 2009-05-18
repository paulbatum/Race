using System.Linq;

namespace Race.Domain
{
    public class DefaultEndCondition : IEndCondition
    {
        public bool IsGameOver(Game game)
        {
            return game.Players.All(p => p.Tableau.CardCount < 12);
        }
    }
}