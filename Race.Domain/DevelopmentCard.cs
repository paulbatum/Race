namespace Race.Domain
{
    public abstract class DevelopmentCard : Card
    {
        protected DevelopmentCard(CardCategory category, int cost, int pointValue) : base(category, cost, pointValue)
        {
            
        }
    }
}