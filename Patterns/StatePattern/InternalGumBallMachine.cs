using Patterns.StatePattern.States;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace Patterns.StatePattern
{
    internal class InternalGumBallMachine : IInternalGumBallMachine
    {
        private IState _hasCoinState;
        private IState _noGumBallState;
        private IState _noCoinState;
        private IState _gumBallSoldState;
        private IState _currentState;

        private int _gumBallCount;

        public InternalGumBallMachine() : this(0)
        {
            _currentState = _noGumBallState;
        }

        public InternalGumBallMachine(int gumballs)
        {
            _hasCoinState = new HasCoinState(this);
            _noGumBallState = new NoGumBallState(this);
            _noCoinState = new NoCoinState(this);
            _gumBallSoldState = new GumBallSoldState(this);

            _currentState = GetNoGumBallState();
            if (gumballs > 0)
            {
                _currentState = GetNoCoinState();
            }

            _gumBallCount = gumballs;
        }
        public void InsertCoin()
        {
            _currentState.InsertCoin();
        }

        public bool TurnCrank()
        {
            return _currentState.TurnCrank();
        }

        public void Dispense()
        {
            _currentState.Dispense();
        }

        public int GetGumBallCount()
        {
            return _gumBallCount;
        }

        public void ReleaseBall()
        {
            _gumBallCount--;
        }

        public void Refill(int gumBalls)
        {
            _currentState.Refill(gumBalls);
        }

        public void AddGumBalls(int gumBalls)
        {
            _gumBallCount += gumBalls;
        }

        #region STATE MANAGEMENT 

        public void SetState(IState state)
        {
            _currentState = state;
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

        public IState GetGumballSoldState()
        {
            return _gumBallSoldState;
        }

        #endregion
    }
}
