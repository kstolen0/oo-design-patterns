namespace Patterns.StatePattern
{
    public class GumBallMachine : IGumBallMachine
    {
        IInternalGumBallMachine _machine;

        public GumBallMachine() : this(0)
        { }

        public GumBallMachine(int gumballs)
        {
            _machine = new InternalGumBallMachine(gumballs);
        }

        public void InsertCoin()
        {
            _machine.InsertCoin();
        }

        public void Refill(int gumBalls)
        {
            _machine.Refill(gumBalls);
        }

        public bool ReturnCoin()
        {
            return _machine.ReturnCoin();
        }

        public bool TurnCrank()
        {
            return _machine.TurnCrank();
        }
    }
}
