using Patterns.StatePattern.States;

namespace Patterns.StatePattern
{
    public class GumBallMachine
    {
        private IState currentState;

        public GumBallMachine()
        {
            currentState = new NoGumBallState();
        }

        public GumBallMachine(int gumballs)
        {
            currentState = new NoCoinState();
        }

        public IState GetCurrentState()
        {
            return currentState;
        }

        public void InsertCoin()
        {

        }
    }
}
