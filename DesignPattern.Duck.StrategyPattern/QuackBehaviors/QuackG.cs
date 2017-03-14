using System;

namespace DesignPattern.Duck.StrategyPattern.QuackBehaviors
{
    public class QuackG : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("呱呱叫...");
        }
    }
}