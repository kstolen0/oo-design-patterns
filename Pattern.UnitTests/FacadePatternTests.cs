using FluentAssertions;
using Patterns.FacadePattern;
using Patterns.FacadePattern.Appliances;
using Xunit;

namespace UnitTests
{
    public class FacadePatternTests
    {
        [Fact]
        public void TVIsOffByDefault()
        {
            ITV sut = new TV();

            sut.IsOn().Should().BeFalse();
        }

        [Fact]
        public void TurnTheTVOn()
        {
            ITV sut = new TV();

            sut.TurnOn();

            sut.IsOn().Should().BeTrue();
        }

        [Fact]
        public void TurnTheTVOff()
        {
            ITV sut = new TV();
            sut.TurnOn();

            sut.TurnOff();

            sut.IsOn().Should().BeFalse();
        }

        [Fact]
        public void RadioIsOffByDefault()
        {
            IRadio sut = new Radio();

            sut.IsOn().Should().BeFalse();
        }

        [Fact]
        public void TurnTheRadioOn()
        {
            IRadio sut = new Radio();

            sut.TurnOn();

            sut.IsOn().Should().BeTrue();
        }

        [Fact]
        public void TurnRadioOff()
        {
            IRadio sut = new Radio();

            sut.TurnOff();

            sut.IsOn().Should().BeFalse();
        }

        [Fact]
        public void EntertainmentSystem_AllSystemsOffByDefault()
        {
            IRadio radio = new Radio();
            ITV tv = new TV();
            IEntertainmentSystem sut = new EntertainmentSystem(radio, tv);

            tv.IsOn().Should().BeFalse();
            radio.IsOn().Should().BeFalse();
        }

        [Fact]
        public void EntertainmentSystem_WhenTheTVTurnsOn_TurnTheRadioOff()
        {
            IRadio radio = new Radio();
            radio.TurnOn();
            ITV tv = new TV();
            IEntertainmentSystem sut = new EntertainmentSystem(radio, tv);

            sut.TurnOnTV();

            tv.IsOn().Should().BeTrue();
            radio.IsOn().Should().BeFalse();
        }

        [Fact]
        public void EntertainmentSystem_WhenTheRadioTurnsOn_TurnTheTVOff()
        {
            IRadio radio = new Radio();
            ITV tv = new TV();
            tv.TurnOn();
            IEntertainmentSystem sut = new EntertainmentSystem(radio, tv);

            sut.TurnOnRadio();

            tv.IsOn().Should().BeFalse();
            radio.IsOn().Should().BeTrue();
        }
    }
}
