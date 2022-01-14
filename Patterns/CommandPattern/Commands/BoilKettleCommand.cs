using Patterns.CommandPattern.Appliances;

namespace Patterns.CommandPattern.Commands
{
    public class BoilKettleCommand : ICommand
    {
        private Kettle _kettle;

        public BoilKettleCommand()
        {
            _kettle = new Kettle();
        }

        // for testing
        public BoilKettleCommand(Kettle kettle)
        {
            _kettle = kettle;
        }

        public void Execute()
        {
            _kettle.Boil();
        }
    }
}
