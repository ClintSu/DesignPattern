using DesignPattern.Duck.StrategyPattern.FlyBehaviors;
using DesignPattern.Duck.StrategyPattern.QuackBehaviors;
using System;

namespace DesignPattern.Duck.StrategyPattern.Ducks
{
    public class DuckModel : Duck
    {
        public DuckModel()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new QuackG());
        }

        public override void Display()
        {
            Console.WriteLine("【模型鸭】");
        }
    }
}