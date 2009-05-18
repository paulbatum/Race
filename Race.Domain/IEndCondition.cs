namespace Race.Domain
{
    public interface IEndCondition
    {
        bool IsGameOver(Game game);
    }
}