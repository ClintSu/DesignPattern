using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Beverage.DecoratePattern.Comdiments
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Whip"; //浓缩
        }

        public override double Cost()
        {
            return .5 + beverage.Cost();
        }
    }
}
