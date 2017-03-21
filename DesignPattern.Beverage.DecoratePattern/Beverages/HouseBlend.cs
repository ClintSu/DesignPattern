using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Beverage.DecoratePattern.Beverages
{
    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee"; //混合咖啡
        }
        public override double Cost()
        {
            return .89;
        }
        public override string GetDescription()
        {
            return description;
        }
    }
}
