namespace Patterns.StatePattern.States
{
    public class NoCoinState : State
    {
        private InternalGumBallMachine _gumBallMachine;

        public NoCoinState(InternalGumBallMachine machine)
        {
            _gumBallMachine = machine;
        }

        public override void InsertCoin()
        {
            _gumBallMachine.SetState(_gumBallMachine.GetHasCoinState());
        }
    }
}
