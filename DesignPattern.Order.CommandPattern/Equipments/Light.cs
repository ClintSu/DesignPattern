using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.RemoteControl.CommandPattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("灯亮了");
        }

        public void Off()
        {
            Console.WriteLine("灯灭了");
        }
    }
}
