//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Race.Domain
//{
//    public abstract class GamePhase
//    {
//        public void Execute(IEnumerable<PhaseParticipation> participations)
//        {
//            foreach(var participation in participations)
//            {
//                //participation.Player.DrawAndDiscardCards
//                DoPhaseAction(participation);
//            }
//        }

//        protected abstract void DoPhaseAction(PhaseParticipation participation);
//    }

//    public class PhaseParticipation
//    {
//    }

//    public class ExplorePhase : GamePhase
//    {
//        protected override void DoPhaseAction(PhaseParticipation participation)
//        {
            
//        }
//    }

//    public abstract class PhaseSelection
//    {
//        public abstract GamePhase Phase { get; }
//        public abstract SelectionBonus Bonus { get; }
//    }

//    public class ExploreDrawThreeKeepTwo : PhaseSelection
//    {
//        public override GamePhase Phase
//        {
//            get { return GamePhase.Explore; }
//        }

//        public void Execute(bool withBonus)
//        {
            
//        }
//    }
    

//    public abstract class SelectionBonus
//    {
//    }

//    public class GameRound
//    {
//        private readonly IEnumerable<Player> _players;

//        public GameRound(IEnumerable<Player> players)
//        {
//            _players = players;
//        }

//        public void Begin()
//        {
//            var selections = _players.Select(player => player.GetPhaseSelection());
//            var phases = selections
//                .GroupBy(selection => selection.Phase);
                
                



//        }
//    }

//    public class Player
//    {
//        public Hand Hand { get; private set; }

//        public PhaseSelection GetPhaseSelection()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class Hand
//    {
        
//    }

//    public class Card
//    {
        
//    }


//}
