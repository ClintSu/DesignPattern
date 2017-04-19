using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizza pizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine(pizza.GetName());
            Console.WriteLine("----------------------------------------");

            pizza = pizzaStore.OrderPizza("veggle");
            Console.WriteLine(pizza.GetName());
            Console.WriteLine("----------------------------------------");

            pizzaStore = new ChicagoPizzaStore();
            pizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine(pizza.GetName());
            Console.WriteLine("----------------------------------------");

            pizza = pizzaStore.OrderPizza("veggle");
            Console.WriteLine(pizza.GetName());
            Console.WriteLine("----------------------------------------");

            Console.ReadLine();
        }
    }
}
