using FluentAssertions;
using Patterns.StatePattern;
using Patterns.StatePattern.States;
using Xunit;

namespace UnitTests.StatePatternTests
{
    public class ContextClassTests
    {
        [Fact]
        public void GumBallMachine_DefaultConstructor_SetsStateToNoGumBalls()
        {
            var sut = new InternalGumBallMachine();

            IState state = sut.GetCurrentState();

            state.Should().BeOfType<NoGumBallState>();
        }

        [Fact]
        public void GumBallMachine_ConstructWithGumBalls_SetsStateToNoCoin()
        {
            var sut = new InternalGumBallMachine(1);

            IState state = sut.GetCurrentState();

            state.Should().BeOfType<NoCoinState>();
        }

        [Fact]
        public void InsertCoin_SetsStateToHasCoin_WhenInNoCoinState()
        {
            var sut = new InternalGumBallMachine(1);

            sut.InsertCoin();

            sut.GetCurrentState().Should().BeOfType<HasCoinState>();
        }

        [Fact]
        public void TurnCrank_DispensesGumBall_WhenInHasCoinState()
        {
            var sut = new InternalGumBallMachine(1);
            var prevGumBallCount = sut.GetGumBallCount();
            sut.InsertCoin();

            sut.TurnCrank();

            sut.GetGumBallCount().Should().Be(prevGumBallCount - 1);
        }

        [Fact]
        public void TurnCrank_SetsStateToNoCoinState_WhenAtLeastOneGumBallIsLeftAfterDisposal()
        {
            var sut = new InternalGumBallMachine(2);
            sut.InsertCoin();

            sut.TurnCrank();

            sut.GetCurrentState().Should().BeOfType<NoCoinState>();
        }

        [Fact]
        public void TurnCrank_SetsStateToNoGumBallState_WhenNoGumBallsAreLeftAfterDisposal()
        {
            var sut = new InternalGumBallMachine(1);
            sut.InsertCoin();

            sut.TurnCrank();

            sut.GetCurrentState().Should().BeOfType<NoGumBallState>();
        }

        [Fact]
        public void Refill_AddsGumBalls_WhenNoGumBallsAreLeftInMachine()
        {
            var sut = new InternalGumBallMachine();

            sut.Refill(1);

            sut.GetGumBallCount().Should().Be(1);
            sut.GetCurrentState().Should().BeOfType<NoCoinState>();
        }
    }
}
