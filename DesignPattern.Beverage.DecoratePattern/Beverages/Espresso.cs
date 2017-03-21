using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Beverage.DecoratePattern.Beverages
{
    public class Espresso:Beverage
    {
        public Espresso()
        {
            description = "Espresso"; //浓咖啡
        }
        public override double Cost()
        {
            return 1.99;
        }
        public override string GetDescription()
        {
            return description;
        }
    }
}
