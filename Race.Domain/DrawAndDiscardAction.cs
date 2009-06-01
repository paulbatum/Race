using System;
using System.Collections.Generic;

namespace Race.Domain
{
    public class DrawAndDiscardAction
    {
        private Player _player;
        private IList<Card> _keeping;
        private IList<Card> _discarding;

        public void Apply()
        {
            throw new NotImplementedException();
        }
    }
}