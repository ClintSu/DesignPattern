using System;

namespace DesignPattern.Duck.StrategyPattern.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("不会飞。");
        }
    }
}