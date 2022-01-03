using FluentAssertions;
using Patterns.ObserverPattern;
using Patterns.ObserverPattern.Observers;
using Xunit;

namespace UnitTests
{
    public class ObserverPatternTests
    {
        [Fact]
        public void SubjectCanRegisterObservers()
        {
            ISubject sut = new WeatherData();
            IObserver observer = new ForecastDisplay();
            sut.RegisterObserver(observer);
        }

        [Fact]
        public void Subject_WhenChanges_NotifiesRegisteredObservers()
        {
            WeatherData sut = new WeatherData();
            ForecastDisplay observer = new ForecastDisplay();
            sut.RegisterObserver(observer);
            var valueBeforeUpdate = observer.GetValue();

            sut.SetValue(valueBeforeUpdate + 1);
            sut.NotifyObservers();

            observer.GetValue().Should().BeGreaterThan(valueBeforeUpdate);
        }
    }
}
