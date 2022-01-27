using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace Patterns.StatePattern.States
{
    internal class GumBallSoldState : State
    {
        InternalGumBallMachine _machine;
        public GumBallSoldState(InternalGumBallMachine machine)
        {
            _machine = machine;
        }

        public override void Dispense()
        {
            _machine.ReleaseBall();

            if (_machine.GetGumBallCount() > 0)
            {
                _machine.SetState(_machine.GetNoCoinState());
            }
            else
            {
                _machine.SetState(_machine.GetNoGumBallState());
            }
        }
    }
}
