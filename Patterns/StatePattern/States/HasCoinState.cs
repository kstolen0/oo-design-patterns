using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace Patterns.StatePattern.States
{
    internal class HasCoinState : State
    {
        InternalGumBallMachine _machine;
        public HasCoinState(InternalGumBallMachine machine)
        {
            _machine = machine;
        }

        public override bool TurnCrank()
        {
            _machine.SetState(_machine.GetGumballSoldState());
            _machine.Dispense();
            return true;
        }

        public override bool ReturnCoin()
        {
            _machine.SetState(_machine.GetNoCoinState());
            return true;
        }
    }
}
