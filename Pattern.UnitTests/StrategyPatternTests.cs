using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using StrategyPattern.Characters;
using StrategyPattern.Weapons;
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

        [Fact]
        public void Fight_WithSword_ReturnsThreeDamage()
        {
            Character sut = new King(loggerMock.Object);
            sut.SetWeapon(new Sword());

            var result = sut.Fight();

            result.Should().Be(3);
        }

        [Fact]
        public void SetWeapon_WithNull_SetsFists()
        {
            Character sut = new King(loggerMock.Object);
            sut.SetWeapon(null);

            var result = sut.Fight();

            result.Should().Be(1);
        }
    }
}
