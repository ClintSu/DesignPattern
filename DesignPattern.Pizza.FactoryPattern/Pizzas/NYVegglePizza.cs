using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.FactoryMethodPattern
{
    public class NYVegglePizza:Pizza
    {
        public NYVegglePizza()
        {
            name = "NYVegglePizza";
            dough = "Thin crust dough NYVegglePizza";
            sauce = "Marina sauce NYVegglePizza";
            toppings.Add("Grated NYVegglePizza cheese");
        }

        public new void Cut()
        {
          Console.WriteLine("cut it into NYVegglePizza slices");
        }
    }
}
