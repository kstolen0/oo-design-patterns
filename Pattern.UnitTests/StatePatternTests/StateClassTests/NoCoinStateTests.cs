using FluentAssertions;
using Patterns.StatePattern;
using Patterns.StatePattern.States;
using Xunit;

namespace UnitTests.StatePatternTests.StateClassTests
{
    public class NoCoinStateTests
    {
        [Fact]
        public void Initialize_WithGumBallMachine()
        {
            var sut = new NoCoinState(new GumBallMachine());
        }

        [Fact]
        public void InsertCoin_SetsGumBallMachineStateToHasCoinState()
        {
            var gumballmachine = new GumBallMachine();
            var sut = new NoCoinState(gumballmachine);

            sut.InsertCoin();

            gumballmachine.GetCurrentState().Should().BeOfType<HasCoinState>();
        }
    }
}
