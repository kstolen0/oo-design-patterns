using FluentAssertions;
using Patterns.StatePattern;
using Xunit;

namespace UnitTests.StatePatternTests
{
    public class GumBallMachineTests
    {
        [Fact]
        public void TurnCrank_ReturnsFalse_WhenCoinHasNotBeenInserted()
        {
            IGumBallMachine sut = new GumBallMachine(1);

            var result = sut.TurnCrank();

            result.Should().BeFalse();
        }

        [Fact]
        public void TurnCrank_ReturnsTrue_WhenCoinIsFirstInserted()
        {
            IGumBallMachine sut = new GumBallMachine(1);

            sut.InsertCoin();
            var result = sut.TurnCrank();

            result.Should().BeTrue();
        }

        [Fact]
        public void TurnCrank_ReturnsFalse_WhenEmpty()
        {
            IGumBallMachine sut = new GumBallMachine(1);
            var result = false;

            sut.InsertCoin();
            result = sut.TurnCrank();
            sut.InsertCoin();
            result = sut.TurnCrank();

            result.Should().BeFalse();
        }

        [Fact]
        public void GumBallMachine_IsEmpty_WithDefaultConstructor()
        {
            IGumBallMachine sut = new GumBallMachine();

            sut.InsertCoin();
            var result = sut.TurnCrank();

            result.Should().BeFalse();
        }

        [Fact]
        public void Refill_RefillsAnEmptyGumBallMachine()
        {
            IGumBallMachine sut = new GumBallMachine();

            sut.Refill(1);
            sut.InsertCoin();
            var result = sut.TurnCrank();

            result.Should().BeTrue();
        }

        [Fact]
        public void Refill_RemainsEmpty_WhenAddingNegativeNumber()
        {
            IGumBallMachine sut = new GumBallMachine();

            sut.Refill(-5);
            sut.InsertCoin();
            var result = sut.TurnCrank();

            result.Should().BeFalse();
        }
    }
}
