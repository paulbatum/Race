using System;
using Race.Domain.Powers;

namespace Race.Domain
{
    public delegate void CardZoneChanger(CardZone targetZone);

    public abstract class Card
    {
        private CardZone _currentZone;
        private readonly CardZoneChanger _zoneChanger;
        
        public CardCategory Category { get; private set; }
        public int Cost { get; private set; }
        public int PointValue { get; private set; }

        protected Card(CardCategory category, int cost, int pointValue)
        {
            _currentZone = new NullZone();
            _zoneChanger = zone => _currentZone = zone;
            Category = category;
            Cost = cost;
            PointValue = pointValue;
        }

        public void MoveTo(CardZone targetZone)
        {            
            _currentZone.MoveCard(this, targetZone, _zoneChanger);
            _currentZone = targetZone;
        }

        public CardZone CurrentZone
        {
            get { return _currentZone; }
        }

        public virtual void RegisterPowers(PowerRegistry registry)
        {
            
        }
    }

    public class DummyCard : Card
    {
        public DummyCard() 
            : base(CardCategory.None, 0, 0)
        {}
    }

    public enum CardCategory
    {
        None,
        Terraforming,
        Imperium,
        Uplift,
        Alien,
        Rebel
    }

    public class PowerRegistry
    {
        public void Register(Power power)
        {
            throw new NotImplementedException();
        }
    }
}