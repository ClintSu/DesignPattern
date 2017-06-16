using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.RemoteControl.CommandPattern
{
    public class Fan
    {
        public void On()
        {
            Console.WriteLine("风扇开了");
        }

        public void Off()
        {
            Console.WriteLine("风扇关了");
        }
    }
}
