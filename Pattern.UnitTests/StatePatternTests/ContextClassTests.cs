using FluentAssertions;
using Patterns.StatePattern;
using Patterns.StatePattern.States;
using Xunit;

namespace UnitTests.StatePatternTests
{
    public class ContextClassTests
    {
        [Fact]
        public void CreateGumBallMachine()
        {
            var sut = new GumBallMachine();
        }

        [Fact]
        public void GumBallMachine_DefaultConstructor_SetsStateToNoGumBalls()
        {
            var sut = new GumBallMachine();

            IState state = sut.GetCurrentState();

            state.Should().BeOfType<NoGumBallState>();
        }

        [Fact]
        public void GumBallMachine_ConstructWithGumBalls_SetsStateToNoCoin()
        {
            var sut = new GumBallMachine(1);

            IState state = sut.GetCurrentState();

            state.Should().BeOfType<NoCoinState>();
        }

        [Fact]
        public void InsertCoin_SetsStateToHasCoin_WhenInNoCoinState()
        {
            var sut = new GumBallMachine(1);

            sut.InsertCoin();

            sut.GetCurrentState().Should().BeOfType<HasCoinState>();
        }

        [Fact]
        public void InsertCoin_DoesNothing_WhenInNoGumBallsState()
        {
            var sut = new GumBallMachine();

            sut.InsertCoin();

            sut.GetCurrentState().Should().BeOfType<NoGumBallState>();
        }

        [Fact]
        public void InsertCoin_DoesNothing_WhenInHasCoinState()
        {
            var sut = new GumBallMachine(1);

            sut.InsertCoin();
            var prevState = sut.GetCurrentState();
            sut.InsertCoin();

            sut.GetCurrentState().GetType().Should().Be(prevState.GetType());
            sut.GetCurrentState().Should().BeOfType<HasCoinState>();
        }
    }
}
