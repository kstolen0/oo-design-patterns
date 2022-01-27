using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace Patterns.StatePattern.States
{
    internal class NoGumBallState : State
    {
        InternalGumBallMachine _machine;

        public NoGumBallState(InternalGumBallMachine machine)
        {
            _machine = machine;
        }

        public override void Refill(int gumBalls)
        {
            if (gumBalls > 0)
            {
                _machine.AddGumBalls(gumBalls);
                _machine.SetState(_machine.GetNoCoinState());
            }
        }
    }
}
