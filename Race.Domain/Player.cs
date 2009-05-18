using System;
using System.Linq;

namespace Race.Domain
{
    public class Player
    {
        public string Name { get; set; }
        public Hand Hand { get; private set; }
        public Tableau Tableau { get; private set; }

        public Player()
        {
            Hand = new Hand();
            Tableau = new Tableau();
        }
    }

    public class Tableau : CardZone
    {
    }

    public class Hand : CardZone
    {
        
    }
}