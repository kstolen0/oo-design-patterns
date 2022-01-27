namespace Patterns.StatePattern.States
{
    public class HasCoinState : State
    {
        InternalGumBallMachine _machine;
        public HasCoinState(InternalGumBallMachine machine)
        {
            _machine = machine;
        }

        public override void TurnCrank()
        {
            _machine.SetState(_machine.GetGumballSoldState());
            _machine.Dispense();
        }
    }
}
