using System;

namespace DesignPattern.Duck.StrategyPattern
{
    public abstract class Duck
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        public Duck()
        {
        }

        public abstract void Display();

        public void PerfomrQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        //鸭子长相不同
        /// <summary>
        /// 设置飞行行为
        /// </summary>
        /// <param name="fb"></param>
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        /// <summary>
        /// 设置叫声行为
        /// </summary>
        /// <param name="qb"></param>
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void Swim()
        {
            Console.WriteLine("会浮水。");
        }       //鸭子浮水
    }
}