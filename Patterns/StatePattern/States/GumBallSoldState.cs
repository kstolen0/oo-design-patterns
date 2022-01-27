namespace Patterns.StatePattern.States
{
    public class GumBallSoldState : State
    {
        GumBallMachine _machine;
        public GumBallSoldState(GumBallMachine machine)
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
