using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace Race.Contracts
{
    [DataContract]
    public class GameState
    {
        [DataMember]
        public Player Me { get; set; }

        [DataMember]
        public Opponent[] Opponents { get; set; }
    }

    [DataContract]
    public class Player
    {
        [DataMember]
        public Card[] Hand { get; set; }

        [DataMember]
        public Card[] Tableau { get; set; }
    }

    [DataContract]
    public class Opponent
    {
        [DataMember]
        public int CardsInHand { get; set; }

        [DataMember]
        public Card[] Tableau { get; set; }
    }

    [DataContract]
    public class Card
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Cost { get; set; }

        [DataMember]
        public int PointValue { get; set; }
    }
}
