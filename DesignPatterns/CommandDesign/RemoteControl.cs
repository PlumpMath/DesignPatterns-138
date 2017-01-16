using DesignPatterns.CommandDesign.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandDesign
{
    public class RemoteControl
    {
        List<ICommand> onCommands;
        List<ICommand> offCommands;
        ICommand undoCommand;

        public RemoteControl()
        {
            var noCommand = new NoCommand();
            onCommands = new List<ICommand>(7);
            offCommands = new List<ICommand>(7);
            undoCommand = noCommand;
            for (int i = 0; i < 7; i++)
            {
                onCommands.Add(noCommand);
                offCommands.Add(noCommand);
            }
        }
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot-1] = onCommand;
            offCommands[slot-1] = offCommand;
        }

        public void OnButtonPressed(int slot)
        {
            onCommands[slot-1].Execute();
            undoCommand = onCommands[slot-1];
        }
        public void OffButtonPressed(int slot)
        {
            offCommands[slot-1].Execute();
            undoCommand = offCommands[slot-1];
        }

        public void Undo()
        {
            undoCommand.Undo();
        }

    }
}
