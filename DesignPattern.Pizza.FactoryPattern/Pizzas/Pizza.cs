using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pizza.FactoryMethodPattern
{
    public abstract class Pizza
    {
        public string name; //名称
        public string dough; //生面团（钱）
        public string sauce; //酱汁（烈酒）

        public ArrayList toppings = new ArrayList();
        /// <summary>
        /// 配备
        /// </summary>
        public void Prepare()
        {
            Console.WriteLine("Preparing "+name);
            Console.WriteLine("Tossign dough..."+ dough);
            Console.WriteLine("Adding sauce..." + sauce);
            Console.WriteLine("Adding toppings...");
            for(int i=0;i<toppings.Count;i++)
            {
                Console.WriteLine(" " + toppings[i]);
            }
        }

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

    }
}
