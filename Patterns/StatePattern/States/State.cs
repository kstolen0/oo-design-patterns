namespace Patterns.StatePattern.States
{
    public abstract class State : IState
    {
        public virtual void Dispense()
        { }

        public virtual void InsertCoin()
        { }

        public virtual void TurnCrank()
        { }
    }
}
