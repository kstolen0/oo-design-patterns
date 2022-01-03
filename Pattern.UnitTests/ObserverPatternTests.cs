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
        public void SubjectCanRemoveObservers()
        {
            ISubject sut = new WeatherData();
            IObserver observer = new ForecastDisplay();
            sut.RegisterObserver(observer);
            sut.RemoveObserver(observer);
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

        [Fact]
        public void WhenObserverIsRemovedFromSubject_ObserverIsNotNotified()
        {
            WeatherData sut = new WeatherData();
            ForecastDisplay observerToKeep = new ForecastDisplay();
            ForecastDisplay observerToRemove = new ForecastDisplay();
            sut.RegisterObserver(observerToKeep);
            sut.RegisterObserver(observerToRemove);
            sut.SetValue(sut.GetValue() + 1);
            sut.NotifyObservers();

            sut.RemoveObserver(observerToRemove);
            sut.SetValue(sut.GetValue() + 1);
            sut.NotifyObservers();

            observerToKeep.GetValue().Should().BeGreaterThan(observerToRemove.GetValue());
        }
    }
}
