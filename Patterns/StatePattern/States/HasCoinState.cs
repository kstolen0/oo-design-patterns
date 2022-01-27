namespace Patterns.StatePattern.States
{
    public class HasCoinState : State
    {
        GumBallMachine _machine;
        public HasCoinState(GumBallMachine machine)
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
