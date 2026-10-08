using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments
{
    internal class Syrup : CondimentDecorator
    {
        public Syrup(Beverage beverage) : base(beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return 0.40 + base.cost() + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Syrup";
        }
    }
}