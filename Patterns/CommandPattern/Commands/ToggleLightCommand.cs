using Patterns.CommandPattern.Lights;

namespace Patterns.CommandPattern.Commands
{
    public class ToggleLightCommand : ICommand
    {
        Light _light;

        public ToggleLightCommand(Light lightLocation)
        {
            _light = lightLocation;
        }

        public void Execute()
        {
            _light.ToggleLights();
        }

        public void Undo()
        {
            _light.ToggleLights();
        }
    }
}
