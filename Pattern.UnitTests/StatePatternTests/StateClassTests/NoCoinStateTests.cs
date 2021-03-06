using FluentAssertions;
using Patterns.StatePattern;
using Patterns.StatePattern.States;
using Xunit;

namespace UnitTests.StatePatternTests.StateClassTests
{
    public class NoCoinStateTests
    {
        [Fact]
        public void InsertCoin_SetsGumBallMachineStateToHasCoinState()
        {
            var gumballmachine = new InternalGumBallMachine();
            var sut = new NoCoinState(gumballmachine);

            sut.InsertCoin();

            gumballmachine.GetCurrentState().Should().BeOfType<HasCoinState>();
        }

        [Fact]
        public void TurnCrank_ReturnsFalse()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumballCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new NoCoinState(gumBallMachine);

            var hasGumBall = sut.TurnCrank();

            hasGumBall.Should().BeFalse();
            gumBallMachine.GetGumBallCount().Should().Be(gumballCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }

        [Fact]
        public void ReturnCoin_ReturnsFalse()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var sut = new NoCoinState(gumBallMachine);

            var result = sut.ReturnCoin();

            result.Should().BeFalse();
        }

        [Fact]
        public void Dispense_DoesNothing()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new NoCoinState(gumBallMachine);

            sut.Dispense();

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }
        [Fact]
        public void Refill_DoesNothing()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new NoCoinState(gumBallMachine);

            sut.Refill(1);

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }
    }
}
