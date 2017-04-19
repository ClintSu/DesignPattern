using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.AbstractFactoryPattern
{
    public interface PizzaIngredientFactory
    {
        //在接口中，每个原料都有一个对应的方法创建该原料 
        Dough CreateDough();

        Sauce CreateSauce();

        Cheese CreateCheese();

        Veggies[] CreateVeggies();

        Pepperoni CreatePepperoni();

        Clams CreateClams();
    }
}
