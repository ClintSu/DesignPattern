using DesignPattern.Duck.StrategyPattern.Ducks;
using System;

namespace DesignPattern.Duck.StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DuckRedHead redhead = new DuckRedHead();
            redhead.Display();
            redhead.Swim();
            redhead.PerformFly();
            redhead.PerfomrQuack();

            DuckModel model = new DuckModel();
            model.Display();
            model.Swim();
            model.PerformFly();
            model.PerfomrQuack();

            Console.ReadLine();
        }
    }
}