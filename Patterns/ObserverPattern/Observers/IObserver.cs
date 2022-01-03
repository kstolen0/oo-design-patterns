namespace Patterns.ObserverPattern.Observers
{
    public interface IObserver
    {
        public ISubject Subject { get; }

        public void Update();
    }
}
