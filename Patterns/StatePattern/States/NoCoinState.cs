namespace Patterns.StatePattern.States
{
    public class NoCoinState : State
    {
        private GumBallMachine _gumBallMachine;

        public NoCoinState(GumBallMachine machine)
        {
            _gumBallMachine = machine;
        }

        public override void InsertCoin()
        {
            _gumBallMachine.SetState(_gumBallMachine.GetHasCoinState());
        }
    }
}
