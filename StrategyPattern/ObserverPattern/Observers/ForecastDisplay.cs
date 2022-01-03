namespace Patterns.ObserverPattern.Observers
{
    public class ForecastDisplay : IObserver
    {
        int _value;

        public int GetValue()
        {
            return _value;
        }

        public void Update(int value)
        {
            _value = value;
        }
    }
}
