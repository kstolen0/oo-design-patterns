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
        public void King_FightsWithFists_ByDefault()
        {
            Character sut = new King(loggerMock.Object);

            sut.GetCurrentWeapon().Should().BeEquivalentTo(nameof(Fists));
        }

        [Fact]
        public void Queen_FightsWithFists_ByDefault()
        {
            Character sut = new Queen(loggerMock.Object);

            sut.GetCurrentWeapon().Should().BeEquivalentTo(nameof(Fists));
        }

        [Fact]
        public void Troll_FightsWithFists_ByDefault()
        {
            Character sut = new Troll(loggerMock.Object);

            sut.GetCurrentWeapon().Should().BeEquivalentTo(nameof(Fists));
        }

        [Fact]
        public void Knight_FightsWithSword_ByDefault()
        {
            Character sut = new Knight(loggerMock.Object);

            sut.GetCurrentWeapon().Should().BeEquivalentTo(nameof(Sword));
        }

        [Fact]
        public void Troll_IsStrongerThanHuman()
        {
            Character human = new King(loggerMock.Object);
            Character troll = new Troll(loggerMock.Object);
            human.SetWeapon(new Fists());
            troll.SetWeapon(new Fists());

            var trollDamage = troll.Fight().damage;
            var humanDamage = human.Fight().damage;

            trollDamage.Should().BeGreaterThan(humanDamage);
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
        public void Fight_WithBowAndArrow_ReturnsExpectedDamageAndRange()
        {
            Character sut = new King(loggerMock.Object);
            sut.SetWeapon(new BowAndArrow());

            var result = sut.Fight();

            result.damage.Should().Be(20);
            result.range.Should().Be(8);
            sut.GetCurrentWeapon().Should().BeEquivalentTo(nameof(BowAndArrow));
        }
    }
}
