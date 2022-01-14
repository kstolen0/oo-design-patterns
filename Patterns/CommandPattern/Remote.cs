using Patterns.CommandPattern.Commands;
using System.Collections.Generic;

namespace Patterns.CommandPattern
{
    public class Remote
    {
        public ICommand[] Commands { get; set; }
        public Stack<ICommand> UndoCommand;

        public Remote()
        {
            Commands = new ICommand[4];
            UndoCommand = new Stack<ICommand>();

            var noCommand = new NoCommand();
            for (int i = 0; i < 4; i++)
            {
                Commands[i] = noCommand;
            }
        }

        public void SetCommand(int index, ICommand command)
        {
            // add error handling
            Commands[index] = command;
        }

        public void PushButton(int index)
        {
            // add error handling
            Commands[index].Execute();
            UndoCommand.Push(Commands[index]);
        }

        public void UndoLastCommand()
        {
            if (UndoCommand.Count > 0)
            {
                UndoCommand.Pop()
                    .Undo();
            }

        }
    }
}

