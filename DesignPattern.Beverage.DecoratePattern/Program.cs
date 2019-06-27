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

            //Console.ReadLine();
            Console.WriteLine("---------------------\n");

            // 我买了个苹果手机
            Phone phone = new ApplePhone();
            // 现在想贴膜了
            Decorator applePhoneWithSticker = new Sticker(phone);
            // 扩展贴膜行为
            applePhoneWithSticker.Print();
            Console.WriteLine("----------------------\n");

            // 现在我想有挂件了
            Decorator applePhoneWithAccessories = new Accessories(phone);
            // 扩展手机挂件行为
            applePhoneWithAccessories.Print();
            Console.WriteLine("----------------------\n");

            // 现在我同时有贴膜和手机挂件了
            Sticker sticker = new Sticker(phone);
            Accessories applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
            applePhoneWithAccessoriesAndSticker.Print();

            Console.ReadLine();

        }
    }
}
