using Patterns.CommandPattern.Commands;

namespace Patterns.CommandPattern
{
    public class Remote
    {
        public ICommand[] Commands { get; set; }

        public Remote()
        {
            Commands = new ICommand[4];

            var noCommand = new NoCommand();
            for (int i = 0; i < 4; i++)
            {
                Commands[i] = noCommand;
            }
        }
    }
}

