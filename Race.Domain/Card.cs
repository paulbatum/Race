namespace Race.Domain
{
    public class Card
    {
        private CardZone _currentZone;
        private readonly CardZoneChanger _zoneChanger;

        public Card()
        {
            _currentZone = new NullZone();
            _zoneChanger = zone => _currentZone = zone;
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
    }
}