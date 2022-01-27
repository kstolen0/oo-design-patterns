namespace Patterns.StatePattern.States
{
    public class GumBallSoldState : IState
    {
        GumBallMachine _machine;
        public GumBallSoldState(GumBallMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
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

        public void InsertCoin()
        {
        }

        public void TurnCrank()
        {
        }
    }
}
