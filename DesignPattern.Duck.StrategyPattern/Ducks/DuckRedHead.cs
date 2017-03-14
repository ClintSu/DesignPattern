using DesignPattern.Duck.StrategyPattern.FlyBehaviors;
using DesignPattern.Duck.StrategyPattern.QuackBehaviors;
using System;

namespace DesignPattern.Duck.StrategyPattern.Ducks
{
    public class DuckRedHead : Duck
    {
        public DuckRedHead()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new QuackG());
        }

        public override void Display()
        {
            Console.WriteLine("【红头鸭】");
        }
    }
}