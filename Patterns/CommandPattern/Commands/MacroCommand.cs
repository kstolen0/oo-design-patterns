using System;

namespace Patterns.CommandPattern.Commands
{
    public class MacroCommand : ICommand
    {
        ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            AllCommands(c => c.Execute());

        }

        public void Undo()
        {
            AllCommands(c => c.Undo());
        }

        private void AllCommands(Action<ICommand> action)
        {
            foreach (ICommand c in _commands)
            {
                action(c);
            }
        }
    }
}
