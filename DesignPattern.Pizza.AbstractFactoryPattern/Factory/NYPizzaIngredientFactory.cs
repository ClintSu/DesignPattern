using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.AbstractFactoryPattern
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        Cheese PizzaIngredientFactory.CreateCheese()
        {
            return new Cheese(); // return new ReggianoCheese();
        }

        Clams PizzaIngredientFactory.CreateClams()
        {
            return new Clams();
        }

        Dough PizzaIngredientFactory.CreateDough()
        {

            return new Dough();
        }


        Pepperoni PizzaIngredientFactory.CreatePepperoni()
        {
            return new Pepperoni();
        }

        Sauce PizzaIngredientFactory.CreateSauce()
        {
            return new Sauce();
        }

        Veggies[] PizzaIngredientFactory.CreateVeggies()
        {
            Veggies[] veggies = { };
            return veggies;
        }
    }
}
