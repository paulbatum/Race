namespace Race.Domain
{
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