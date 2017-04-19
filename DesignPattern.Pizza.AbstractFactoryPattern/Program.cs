using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYPizzaStore();
            pizzaStore.OrderPizza("cheese");
            //Pizza pizza= 
        }
    }
}
