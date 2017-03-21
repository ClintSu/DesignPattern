using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Beverage.DecoratePattern.Comdiments
{
    public class Soy:CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .3 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Soy";  //奶泡
        }

    }
}
