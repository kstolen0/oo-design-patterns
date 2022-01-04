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
            IBeverage sut = new DarkRoast();
        }

        [Fact]
        public void GetDarkRoastCost()
        {
            IBeverage sut = new DarkRoast();

            sut.Cost();
        }

        [Fact]
        public void AddSoyToDarkRoast()
        {
            IBeverage sut = new DarkRoast();
            sut = new Soy(sut);
        }
    }
}
