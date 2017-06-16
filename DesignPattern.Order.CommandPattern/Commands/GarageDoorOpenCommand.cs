using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.RemoteControl.CommandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor door;
        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Open();
        }

    }
}
