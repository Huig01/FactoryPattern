using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected Beverage baseBeverage = null;
        public CondimentDecorator(Beverage baseBeverage)
        {
            this.baseBeverage = baseBeverage;
        }
        public abstract override string GetDescription();

    }
}
