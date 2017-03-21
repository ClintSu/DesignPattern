using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Beverage.DecoratePattern.Beverages;
using DesignPattern.Beverage.DecoratePattern.Comdiments;

namespace DesignPattern.Beverage.DecoratePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage= new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2=new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription()+" $"+beverage2.Cost());

            Beverage beverage3 = new DarkRoase();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());


            Console.ReadLine();
        }
    }
}
