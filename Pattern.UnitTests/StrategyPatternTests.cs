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
        public void CreateKing()
        {
            Character sut = new King(loggerMock.Object);
        }

        [Fact]
        public void King_UnarmedAttack_DealsOneDamage()
        {
            Character sut = new King(loggerMock.Object);

            var result = sut.Fight();

            result.Should().Be(1);
        }
    }
}
