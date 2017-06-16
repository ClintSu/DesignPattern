using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.RemoteControl.CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            GarageDoor garageDoor = new GarageDoor();
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            remote.SetCommand(garageDoorOpen);
            remote.ButtonWasPressed();

            Console.ReadLine();
        }
    }
}
