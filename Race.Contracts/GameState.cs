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
        [DataMember] public Player Me;
        [DataMember] public Opponent[] Opponents;
    }

    [DataContract]
    public class Player
    {
        [DataMember] public Card[] Hand;
        [DataMember] public Card[] Tableau;
    }

    [DataContract]
    public class Opponent
    {
        [DataMember] public int CardsInHand;
        [DataMember] public Card[] Tableau;
    }

    [DataContract]
    public class Card
    {
        [DataMember] public string Name;
        [DataMember] public int Cost;
        [DataMember] public int PointValue;
    }
}
