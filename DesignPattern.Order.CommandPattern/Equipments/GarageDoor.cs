using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.RemoteControl.CommandPattern
{
    public class GarageDoor
    {
        public void Open()
        {
            Console.WriteLine("车库门开了");
        }

        public void Close()
        {
            Console.WriteLine("车库门关了");
        }
    }
}
