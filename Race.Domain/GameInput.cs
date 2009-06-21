using System;
using System.Collections;
using System.Collections.Generic;
using Race.Domain.Actions;

namespace Race.Domain
{
    public class GameInput
    {
        public IEnumerable<DrawAndDiscardAction> GetOpeningDiscards()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ActionCardSelection> GetActionCardSelections()
        {
            throw new NotImplementedException();
        }

        public void DoExplore(IEnumerable<ExploreAction> exploreActions)
        {
            throw new NotImplementedException();
        }

        public void DoDevelop(IEnumerable<DevelopAction> developActions)
        {
            throw new NotImplementedException();
        }
    }
}