using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.FactoryMethodPattern
{
   public class ChicagoPizzaStore:PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = new ChicagoCheesePizza();
            }
            else if (type.Equals("veggle"))
            {
                pizza = new ChicagoVegglePizza();
            }
            return pizza;
        }
    }
}
