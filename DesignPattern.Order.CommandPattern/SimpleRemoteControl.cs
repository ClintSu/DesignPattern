using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.RemoteControl.CommandPattern
{
    public class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl() { }

        public void SetCommand(ICommand command)
        {
            slot = command;
        }
        public void ButtonWasPressed()
        {
            slot.Execute();
        }

    }
}
