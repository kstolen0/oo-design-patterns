namespace Patterns.StatePattern.States
{
    public class HasCoinState : IState
    {
        GumBallMachine _machine;
        public HasCoinState(GumBallMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
        }

        public void InsertCoin()
        {
        }

        public void TurnCrank()
        {
            _machine.SetState(_machine.GetGumballSoldState());
            _machine.Dispense();
        }
    }
}
