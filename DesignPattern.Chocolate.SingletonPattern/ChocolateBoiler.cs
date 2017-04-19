using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chocolate.SingletonPattern
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        public bool IsEmpty() { return empty; }
        public bool IsBoilded() { return boiled; }

        private volatile static ChocolateBoiler uniqueInstance;
        private static readonly object lockObj = new object();
        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (lockObj)
                {
                    if (uniqueInstance == null)
                        uniqueInstance = new ChocolateBoiler();
                }
            }
            return uniqueInstance;
        }

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        /// <summary>
        /// 填充
        /// </summary>
        public void Fill()
        {
            if (IsEmpty()) { empty = false;boiled = false; }
        }
        /// <summary>
        /// 排出
        /// </summary>
        public void Drain()
        {
            if(!IsEmpty()&& IsBoilded())
            {
                empty = true;
            }
        }
        /// <summary>
        /// 煮沸
        /// </summary>
        public void Boil()
        {
            if (!IsEmpty() && !IsBoilded())
            {
                boiled = true;
            }
        }


    }
}
