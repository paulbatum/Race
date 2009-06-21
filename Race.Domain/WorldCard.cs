namespace Race.Domain
{
    public abstract class WorldCard : Card
    {
        public bool IsMilitary { get; private set; }
        public bool IsWindfall { get; private set; }
        public GoodType GoodType { get; private set; }

        protected WorldCard(CardCategory category, int cost, int pointValue, bool isMilitary, bool isWindfall, GoodType goodType) 
            : base(category, cost, pointValue)
        {
            IsMilitary = isMilitary;
            IsWindfall = isWindfall;
            GoodType = goodType;
        }
    }

    public enum GoodType
    {
        None,
        Novelty,
        RareElements,
        Genes,
        AlienTechnology
    }

    
}