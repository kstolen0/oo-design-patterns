namespace Patterns.StatePattern.States
{
    public interface IState
    {
        void InsertCoin();

        bool TurnCrank();

        void Dispense();

        void Refill(int gumBalls);

        bool ReturnCoin();
    }
}
