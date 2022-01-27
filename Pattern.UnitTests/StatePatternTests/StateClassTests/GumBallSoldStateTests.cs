using FluentAssertions;
using Patterns.StatePattern;
using Patterns.StatePattern.States;
using Xunit;

namespace UnitTests.StatePatternTests.StateClassTests
{
    public class GumBallSoldStateTests
    {
        [Fact]
        public void Dispense_ReleasesGumBallFromMachine()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var sut = new GumBallSoldState(gumBallMachine);

            sut.Dispense();

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount - 1);
        }

        [Fact]
        public void Dispense_SetsMachineStateToNoGumBalls_WhenNoGumBallsAreLeftAfterDisposal()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var sut = new GumBallSoldState(gumBallMachine);

            sut.Dispense();

            gumBallMachine.GetCurrentState().Should().BeOfType<NoGumBallState>();
        }

        [Fact]
        public void Dispense_SetsMachineStateToNoCoin_WhenGumBallsAreLeftAfterDisposal()
        {
            var gumBallMachine = new InternalGumBallMachine(2);
            var sut = new GumBallSoldState(gumBallMachine);

            sut.Dispense();

            gumBallMachine.GetCurrentState().Should().BeOfType<NoCoinState>();
        }

        [Fact]
        public void TurnCrank_ReturnsFalse()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new GumBallSoldState(gumBallMachine);

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
            var sut = new GumBallSoldState(gumBallMachine);

            sut.InsertCoin();

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }

        [Fact]
        public void Refill_DoesNothing()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new GumBallSoldState(gumBallMachine);

            sut.Refill(1);

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }
    }
}
