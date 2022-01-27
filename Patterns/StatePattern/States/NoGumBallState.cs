namespace Patterns.StatePattern.States
{
    public class NoGumBallState : State
    {
        GumBallMachine _machine;

        public NoGumBallState(GumBallMachine machine)
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
