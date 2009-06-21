using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Race.Domain.Powers;

namespace Race.Domain.Cards
{
    public class InvestmentCredits : DevelopmentCard
    {
        public InvestmentCredits() 
            : base(CardCategory.None, 1, 1)
        {}

        public override void RegisterPowers(PowerRegistry registry)
        {
            base.RegisterPowers(registry);
            registry.Register(new ReduceCostPower(1));
        }

    }

    public class RadioactiveWorld : WorldCard
    {
        public RadioactiveWorld() 
            : base(CardCategory.None, 2, 1, false, true, GoodType.RareElements)
        {}
    }
}
