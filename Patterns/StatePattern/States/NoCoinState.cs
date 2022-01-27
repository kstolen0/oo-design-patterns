namespace Patterns.StatePattern.States
{
    public class NoCoinState : IState
    {
        private GumBallMachine _gumBallMachine;

        public NoCoinState(GumBallMachine machine)
        {
            _gumBallMachine = machine;
        }

        public void Dispense()
        {
        }

        public void InsertCoin()
        {
            _gumBallMachine.SetState(_gumBallMachine.GetHasCoinState());
        }

        public void TurnCrank()
        {
        }
    }
}
