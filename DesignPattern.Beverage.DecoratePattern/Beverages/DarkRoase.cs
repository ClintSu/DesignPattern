using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Beverage.DecoratePattern.Beverages
{
    public class DarkRoase:Beverage
    {
        public DarkRoase()
        {
            description = "DarkRoase";  //深焙
        }

        public override double Cost()
        {
            return 1.11;
        }

        public override string GetDescription()
        {
            return description;
        }
    }
}
