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
    }
}
