namespace Patterns.ObserverPattern.Observers
{
    public class ForecastDisplay : IObserver
    {
        int _value;

        public ISubject Subject { get; }

        public ForecastDisplay(ISubject subject)
        {
            Subject = subject;
        }

        public int GetValue()
        {
            return _value;
        }

        public void Update()
        {
            _value = Subject.GetValue();

        }
    }
}
