using Patterns.CommandPattern.Commands;

namespace Patterns.CommandPattern
{
    public class Remote
    {
        public ICommand[] Commands { get; set; }
        public ICommand UndoCommand;

        public Remote()
        {
            Commands = new ICommand[4];

            var noCommand = new NoCommand();
            for (int i = 0; i < 4; i++)
            {
                Commands[i] = noCommand;
            }

            UndoCommand = noCommand;
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
            UndoCommand = Commands[index];
        }

        public void UndoLastCommand()
        {
            UndoCommand.Undo();
        }
    }
}

