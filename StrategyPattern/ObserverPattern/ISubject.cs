using Patterns.ObserverPattern.Observers;

namespace Patterns.ObserverPattern
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);

        public void NotifyObservers();
    }
}
