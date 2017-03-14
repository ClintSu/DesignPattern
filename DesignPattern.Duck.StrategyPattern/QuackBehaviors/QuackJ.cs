using System;

namespace DesignPattern.Duck.StrategyPattern.QuackBehaviors
{
    public class QuackJ : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("唧唧叫...");
        }
    }
}