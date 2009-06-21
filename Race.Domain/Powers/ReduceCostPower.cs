using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race.Domain.Powers
{
    public class ReduceCostPower : Power
    {
        public int ReductionAmount { get; private set; }

        public ReduceCostPower(int amount)
        {
            ReductionAmount = amount;
        }

        public override bool AppliesTo(GameAction action)
        {
            return action is DevelopAction;
        } 
        
    }

    
}