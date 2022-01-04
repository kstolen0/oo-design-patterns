using FluentAssertions;
using Patterns.DecoratorPattern.Beverages;
using Patterns.DecoratorPattern.Condiments;
using Xunit;

namespace UnitTests
{
    public class DecoratorPatternTests
    {
        [Fact]
        public void CreateBeverage()
        {
            Beverage sut = new DarkRoast();
        }

        [Fact]
        public void DarkRoast_Costs_Four()
        {
            Beverage sut = new DarkRoast();

            sut.Cost().Should().Be((long)4.0);
        }

        [Fact]
        public void DarkRoastWithSoy_Costs_FourPointFive()
        {
            Beverage sut = new DarkRoast();
            sut = new Soy(sut);

            sut.Cost().Should().Be((long)4.5);
        }

        [Fact]
        public void DarkRoastWithSoyAndExtraShot_Costs_FivePointFive()
        {
            Beverage sut = new DarkRoast();
            sut = new ExtraShot(sut);
            sut = new Soy(sut);

            sut.Cost().Should().Be((long)5.5);
        }

        [Fact]
        public void SetBeverageSize()
        {
            Beverage sut = new DarkRoast();
            sut.SetSize(Beverage.Size.SMALL);
        }

        [Fact]
        public void GetBeverageSize()
        {
            Beverage sut = new DarkRoast();
            sut.SetSize(Beverage.Size.LARGE);
            sut.GetSize().Should().Be(Beverage.Size.LARGE);
        }
    }
}
