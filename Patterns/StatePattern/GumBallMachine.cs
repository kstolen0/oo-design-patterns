using Patterns.StatePattern.States;

namespace Patterns.StatePattern
{
    public class GumBallMachine
    {
        private IState _hasCoinState;
        private IState _noGumBallState;
        private IState _noCoinState;
        private IState _currentState;

        public GumBallMachine() : this(0)
        {
            _currentState = _noGumBallState;
        }

        public GumBallMachine(int gumballs)
        {
            _hasCoinState = new HasCoinState();
            _noGumBallState = new NoGumBallState();
            _noCoinState = new NoCoinState(this);

            _currentState = GetNoGumBallState();
            if (gumballs > 0)
            {
                _currentState = GetNoCoinState();
            }
        }

        public IState GetCurrentState()
        {
            return _currentState;
        }

        public IState GetHasCoinState()
        {
            return _hasCoinState;
        }

        public IState GetNoCoinState()
        {
            return _noCoinState;
        }

        public IState GetNoGumBallState()
        {
            return _noGumBallState;
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public void InsertCoin()
        {
            _currentState.InsertCoin();
        }

    }
}
