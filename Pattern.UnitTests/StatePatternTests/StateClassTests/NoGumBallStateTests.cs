using FluentAssertions;
using Patterns.StatePattern;
using Patterns.StatePattern.States;
using Xunit;

namespace UnitTests.StatePatternTests.StateClassTests
{
    public class NoGumBallStateTests
    {
        [Fact]
        public void Refill_AddsGumballsToGumBallMachine()
        {
            var gumBallMachine = new InternalGumBallMachine();
            var sut = new NoGumBallState(gumBallMachine);

            sut.Refill(2);

            gumBallMachine.GetGumBallCount().Should().Be(2);
            gumBallMachine.GetCurrentState().Should().BeOfType<NoCoinState>();
        }

        [Fact]
        public void Refill_DoesNothing_WhenInputLessThanOne()
        {
            var gumBallMachine = new InternalGumBallMachine();
            var sut = new NoGumBallState(gumBallMachine);

            sut.Refill(-5);

            gumBallMachine.GetGumBallCount().Should().Be(0);
            gumBallMachine.GetCurrentState().Should().BeOfType<NoGumBallState>();
        }

        [Fact]
        public void Dispense_DoesNothing()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new NoGumBallState(gumBallMachine);

            sut.Dispense();

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }

        [Fact]
        public void TurnCrank_ReturnsFalse()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new NoGumBallState(gumBallMachine);

            var hasGumBall = sut.TurnCrank();

            hasGumBall.Should().BeFalse();
            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }

        [Fact]
        public void InsertCoin_DoesNothing()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new NoGumBallState(gumBallMachine);

            sut.InsertCoin();

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }
    }
}
