using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.RemoteControl.CommandPattern
{
    public class LightOnCommand : ICommand
    {
        Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }
}
