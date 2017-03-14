using System;

namespace DesignPattern.Duck.StrategyPattern.FlyBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("用翅膀飞。");
        }
    }
}