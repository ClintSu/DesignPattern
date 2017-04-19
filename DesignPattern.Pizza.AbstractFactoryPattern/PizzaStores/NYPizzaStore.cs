using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.AbstractFactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if(type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
            }
            else if ("clam".Equals(type))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("New York Style Clam Pizza");
            }
            return pizza;
        }
    }
}
