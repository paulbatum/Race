using System;

namespace Race.Domain
{
    public class Player
    {
        public string Name { get; set; }

        public Hand Hand
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class Hand : CardZone
    {
        
    }
}