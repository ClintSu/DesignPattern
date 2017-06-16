using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.RemoteControl.CommandPattern
{
    public class Heater
    {
        public void On()
        {
            Console.WriteLine("加热中");
        }

        public void Off()
        {
            Console.WriteLine("停止加热");
        }
    }
}
