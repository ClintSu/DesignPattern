using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Beverage.DecoratePattern
{
    public abstract class Beverage
    {
        public string description = "Unknow Beverage";

        public abstract string GetDescription();

        public abstract double Cost();
    }
}
