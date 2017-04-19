using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.FactoryMethodPattern
{
    public class NYCheesePizza:Pizza
    {
        public NYCheesePizza()
        {
            name = "NYCheesePizza";
            dough = "Thin crust dough NYCheesePizza";
            sauce = "Marina sauce NYCheesePizza";
            toppings.Add("Grated NYCheesePizza chesse");
        }

        public new void Cut()
        {
            Console.WriteLine("cut it into NYCheesePizza slices");
        }
    }
}
