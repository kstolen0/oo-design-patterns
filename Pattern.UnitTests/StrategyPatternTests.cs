using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using StrategyPattern.Characters;
using Xunit;

namespace UnitTests
{
    public class StrategyPatternTests
    {
        Mock<ILogger<Character>> loggerMock = new Mock<ILogger<Character>>();

        [Fact]
        public void King_UnarmedAttack_DealsOneDamage()
        {
            Character sut = new King(loggerMock.Object);

            var result = sut.Fight();

            result.Should().Be(1);
        }

        [Fact]
        public void Queen_UnarmedAttack_DealsOneDamage()
        {
            Character sut = new Queen(loggerMock.Object);

            var result = sut.Fight();

            result.Should().Be(1);
        }
    }
}
