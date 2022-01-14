using FluentAssertions;
using Patterns.CommandPattern;
using Patterns.CommandPattern.Appliances;
using Patterns.CommandPattern.Commands;
using Patterns.CommandPattern.Lights;
using Xunit;

namespace UnitTests
{
    public class CommandPatternTests
    {
        [Fact]
        public void RemoteContainsOnlyNoCommandObjectsByDefaults()
        {
            var remote = new Remote();

            foreach (ICommand c in remote.Commands)
            {
                c.Should().BeOfType<NoCommand>();
            }
        }

        [Fact]
        public void SetCommand_WithLightToggleObject()
        {
            var remote = new Remote();

            remote.SetCommand(0, new ToggleLightCommand(new KitchenLights()));

            remote.Commands[0].Should().BeOfType<ToggleLightCommand>();
        }

        [Fact]
        public void PushButton_ExecutesCommand()
        {
            var remote = new Remote();
            var kitchenLights = new KitchenLights();
            var previousLightState = kitchenLights.IsLightOn();
            remote.SetCommand(0, new ToggleLightCommand(kitchenLights));

            remote.PushButton(0);

            kitchenLights.IsLightOn().Should().Be(!previousLightState);
        }

        [Fact]
        public void PushButton_TurnsOnTheKettle()
        {
            var remote = new Remote();
            var kettle = new Kettle();
            remote.SetCommand(0, new BoilKettleCommand(kettle));

            remote.PushButton(0);

            kettle.IsWaterBoiled().Should().BeTrue();
        }

        [Fact]
        public void PushButton_AddCommandToUndoLastCommand()
        {
            var remote = new Remote();
            remote.SetCommand(0, new BoilKettleCommand());
            remote.SetCommand(1, new ToggleLightCommand(new KitchenLights()));

            remote.PushButton(0);

            remote.UndoCommand.Pop().Should().BeOfType<BoilKettleCommand>();
        }

        [Fact]
        public void UndoLastCommand_UndoesTheLastCommand()
        {
            var remote = new Remote();
            var kitchenLights = new KitchenLights();
            var previousLightState = kitchenLights.IsLightOn();
            remote.SetCommand(0, new ToggleLightCommand(kitchenLights));
            remote.PushButton(0);

            remote.UndoLastCommand();

            kitchenLights.IsLightOn().Should().Be(previousLightState);
        }

        [Fact]
        public void PushButton_WithMacroCommand_DoesManyThings()
        {
            var remote = new Remote();
            var kitchenLights = new KitchenLights();
            var kettle = new Kettle();
            var previousLightState = kitchenLights.IsLightOn();
            var macroCommand = new MacroCommand(new ICommand[2] {
                new ToggleLightCommand(kitchenLights),
                new BoilKettleCommand(kettle)
            });
            remote.SetCommand(0, macroCommand);

            remote.PushButton(0);

            kitchenLights.IsLightOn().Should().Be(!previousLightState);
            kettle.IsWaterBoiled().Should().BeTrue();
        }

        [Fact]
        public void UndoLastCommand_UndoesMacroCommand()
        {
            var remote = new Remote();
            var kitchenLights = new KitchenLights();
            var kettle = new Kettle();
            var previousLightState = kitchenLights.IsLightOn();
            var macroCommand = new MacroCommand(new ICommand[2] {
                new ToggleLightCommand(kitchenLights),
                new BoilKettleCommand(kettle)
            });
            remote.SetCommand(0, macroCommand);
            remote.PushButton(0);

            remote.UndoLastCommand();

            kitchenLights.IsLightOn().Should().Be(previousLightState);
            kettle.IsWaterBoiled().Should().BeFalse();
        }

        [Fact]
        public void UndoLastCommand_CanUndoMultipleCommands()
        {
            var remote = new Remote();
            var kitchenLights = new KitchenLights();
            var kettle = new Kettle();
            remote.SetCommand(0, new BoilKettleCommand(kettle));
            remote.SetCommand(1, new ToggleLightCommand(kitchenLights));
            remote.PushButton(0);
            remote.PushButton(1);

            remote.UndoLastCommand();
            remote.UndoLastCommand();

            kettle.IsWaterBoiled().Should().BeFalse();
            kitchenLights.IsLightOn().Should().BeFalse();
        }
    }
}
