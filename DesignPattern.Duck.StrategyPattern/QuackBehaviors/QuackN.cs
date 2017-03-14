using System;

namespace DesignPattern.Duck.StrategyPattern.QuackBehaviors
{
    public class QuackN : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}