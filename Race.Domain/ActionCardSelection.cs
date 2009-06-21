using System;

namespace Race.Domain
{
    //public class ActionCardSelection
    //{
    //    public Player Player { get; private set; }
    //    public ActionCard SelectedActionCard { get; private set; }

    //    public ActionCardSelection(Player player, ActionCard selectedActionCard)
    //    {
    //        Player = player;
    //        SelectedActionCard = selectedActionCard;
    //    }
    //}

    public class ActionCardSelection
    {
        public Player Player { get; private set; }
        public string SelectedPhase { get; private set; }
        public Bonus SelectedBonus { get; private set; }
        public ActionCardSelection(Player player, string selectedPhase, Bonus selectedBonus)
        {
            Player = player;
            SelectedPhase = selectedPhase;
            SelectedBonus = selectedBonus;
        }
    }
}