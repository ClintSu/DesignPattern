using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.FactoryMethodPattern
{
    public class ChicagoVegglePizza:Pizza
    {
        public ChicagoVegglePizza()
        {
            name = "ChicagoVegglePizza";
            dough = "Thin crust dough ChicagoVegglePizza";
            sauce = "Marina sauce ChicagoVegglePizza";
            toppings.Add("Grated ChicagoVegglePizza cheese");
        }

        public new void Cut()
        {
           Console.WriteLine("cut it into ChicagoVegglePizza slices");
        }
    }
}
