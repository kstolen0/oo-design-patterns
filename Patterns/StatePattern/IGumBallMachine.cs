namespace Patterns.StatePattern
{
    public interface IGumBallMachine
    {
        void InsertCoin();
        bool TurnCrank();
        void Refill(int gumBalls);
    }
}
