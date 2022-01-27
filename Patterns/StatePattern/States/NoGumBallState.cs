namespace Patterns.StatePattern.States
{
    public class NoGumBallState : State
    {
        InternalGumBallMachine _machine;

        public NoGumBallState(InternalGumBallMachine machine)
        {
            _machine = machine;
        }

        public override void Refill(int gumBalls)
        {
            _machine.AddGumBalls(gumBalls);
            _machine.SetState(_machine.GetNoCoinState());
        }
    }
}
