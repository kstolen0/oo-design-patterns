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

            sut.TurnCrank();

            gumBallMachine.GetGumBallCount().Should().Be(gumBallCount - 1);
            gumBallMachine.GetCurrentState().Should().BeOfType<NoGumBallState>();
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
