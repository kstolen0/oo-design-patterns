namespace Patterns.StatePattern.States
{
    public interface IState
    {
        void InsertCoin();

        void TurnCrank();

        void Dispense();

        void Refill(int gumBalls);
    }
}
