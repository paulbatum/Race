using System;

namespace Race.Domain
{
    public class ActionCardSelection
    {
        public Player Player { get; private set; }
        public ActionCard SelectedActionCard { get; private set; }

        public ActionCardSelection(Player player, ActionCard selectedActionCard)
        {
            Player = player;
            SelectedActionCard = selectedActionCard;
        }
    }
}