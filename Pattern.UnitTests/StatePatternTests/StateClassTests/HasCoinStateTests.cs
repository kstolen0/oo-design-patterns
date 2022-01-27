using FluentAssertions;
using Patterns.StatePattern;
using Patterns.StatePattern.States;
using Xunit;

namespace UnitTests.StatePatternTests.StateClassTests
{
    public class HasCoinStateTests
    {
        [Fact]
        public void TurnCrank_UpdatesMachineState_AndDispensesGumBall()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var sut = new HasCoinState(gumBallMachine);

            var hasGumBall = sut.TurnCrank();

            hasGumBall.Should().BeTrue();
            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount - 1);
            gumBallMachine.GetCurrentState().Should().BeOfType<NoGumBallState>();
        }

        [Fact]
        public void ReturnCoin_ReturnsTrue()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var sut = new HasCoinState(gumBallMachine);
            gumBallMachine.InsertCoin();

            var result = sut.ReturnCoin();

            result.Should().BeTrue();
        }

        [Fact]
        public void ReturnCoin_SetsMachineStateToNoCoin()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var sut = new HasCoinState(gumBallMachine);
            gumBallMachine.InsertCoin();

            sut.ReturnCoin();

            gumBallMachine.GetCurrentState().Should().BeOfType<NoCoinState>();
        }

        [Fact]
        public void InsertCoin_DoesNothing()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new HasCoinState(gumBallMachine);

            sut.InsertCoin();

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }

        [Fact]
        public void Dispense_DoesNothing()
        {
            var gumBallMachine = new InternalGumBallMachine(1);
            var gumBallCount = gumBallMachine.GetGumBallCount();
            var prevState = gumBallMachine.GetCurrentState();
            var sut = new HasCoinState(gumBallMachine);

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
            var sut = new HasCoinState(gumBallMachine);

            sut.Refill(1);

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount);
            gumBallMachine.GetCurrentState().GetType().Should().Be(prevState.GetType());
        }
    }
}
