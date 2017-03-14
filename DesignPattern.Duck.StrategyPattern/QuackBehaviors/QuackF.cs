using System;

namespace DesignPattern.Duck.StrategyPattern.QuackBehaviors
{
    public class QuackF : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("假叫...");
        }
    }
}