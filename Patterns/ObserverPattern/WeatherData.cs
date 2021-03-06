using Patterns.ObserverPattern.Observers;
using System.Collections.Generic;

namespace Patterns.ObserverPattern
{
    public class WeatherData : ISubject
    {
        int _value;
        IList<IObserver> _observers;

        public WeatherData()
        {
            _value = 1;
            _observers = new List<IObserver>();
        }
        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void SetValue(int value)
        {
            _value = value;
            NotifyObservers();
        }

        public int GetValue()
        {
            return _value;
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
