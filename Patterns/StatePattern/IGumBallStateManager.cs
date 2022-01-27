using Patterns.StatePattern.States;

namespace Patterns.StatePattern
{
    public interface IGumBallStateManager
    {
        void SetState(IState state);

        IState GetCurrentState();

        IState GetHasCoinState();

        IState GetNoCoinState();

        IState GetNoGumBallState();

        IState GetGumballSoldState();
    }
}
