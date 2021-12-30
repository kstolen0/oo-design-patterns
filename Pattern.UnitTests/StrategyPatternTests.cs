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
        public void King_Default_FightsWithFists()
        {
            Character sut = new King(loggerMock.Object);

            sut.GetCurrentWeapon().Should().BeEquivalentTo(nameof(Fists));
        }

        [Fact]
        public void Queen_Default_FightsWithFists()
        {
            Character sut = new Queen(loggerMock.Object);

            var result = sut.Fight();

            sut.GetCurrentWeapon().Should().BeEquivalentTo(nameof(Fists));
        }

        [Fact]
        public void SetWeapon_WithSword_EquipsSword()
        {
            Character sut = new King(loggerMock.Object);
            sut.SetWeapon(new Sword());

            sut.GetCurrentWeapon().Should().Be(nameof(Sword));
        }

        [Fact]
        public void SetWeapon_WithNull_EquipsFists()
        {
            Character sut = new King(loggerMock.Object);
            sut.SetWeapon(null);

            sut.GetCurrentWeapon().Should().Be(nameof(Fists));
        }

        [Fact]
        public void Fight_WithBowAndArrow_ReturnsTwoDamageAndEightRange()
        {
            Character sut = new King(loggerMock.Object);
            sut.SetWeapon(new BowAndArrow());

            var result = sut.Fight();

            result.damage.Should().Be(2);
            result.range.Should().Be(8);
            sut.GetCurrentWeapon().Should().BeEquivalentTo(nameof(BowAndArrow));
        }
    }
}
