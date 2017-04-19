using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.AbstractFactoryPattern
{
    public abstract class Pizza
    {
        public string name; //名称
        public Dough dough; //生面团（钱）
        public Sauce sauce; //酱汁（烈酒）
        public Veggies[] veggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clams;

        //Prepare()方法声明为抽象方法。在这个方法中，我们需要收集披萨所需要的原料，而这些原料都是来自原料工厂
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slince");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

    }
}
