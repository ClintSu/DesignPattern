using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.FactoryMethodPattern
{
    public class ChicagoCheesePizza:Pizza
    {
        public ChicagoCheesePizza()
        {
            name = "ChicagoCheesePizza";
            dough = "Thin crust dough ChicagoCheesePizza";
            sauce = "Marina sauce ChicagoCheesePizza";
            toppings.Add("Grated ChicagoCheesePizza cheese");
        }

        public new void Cut()
        {
            Console.WriteLine("cut it into ChicagoCheesePizza slices");
        }
    }
}
