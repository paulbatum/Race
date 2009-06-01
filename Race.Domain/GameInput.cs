using System;
using System.Collections;
using System.Collections.Generic;

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
    }
}