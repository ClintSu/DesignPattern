using System;

namespace DesignPattern.Duck.StrategyPattern.FlyBehaviors
{
    internal class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("用火箭助飞。");
        }
    }
}